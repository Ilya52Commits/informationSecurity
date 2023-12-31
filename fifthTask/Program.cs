using System;
using System.IO;
using System.Numerics;
using System.Collections.Generic;

namespace informationSecurity;
internal abstract class Program 
{ 
  /* Глобальные переменные */
  // путь к файлам
  private const string Path = @".\Contents\";
  private static BigInteger? _publicKey;
  private static BigInteger? _privateKey;
  private static BigInteger? _n;

  /* Методы */
  // метод составления ключа
  private static void s_setKeys()
  { 
    var p = new BigInteger(2039);
    var q = new BigInteger(4001);
    _n = p * q;
    var fi = (p - BigInteger.One) * (q - BigInteger.One);
    var e = new BigInteger(2);
    var d = new BigInteger(2);
    
    while (true)
    {
      if (s_gcd(e, fi) == BigInteger.One)
        break;
      e += 1;
    }

    _publicKey = e;

    while (true)
    {
      if ((d * e) % fi == BigInteger.One)
        break;
      d += 1;
    }

    _privateKey = d;
  }

  // метод шифра
  private static BigInteger s_encrypt(BigInteger message)
  {
    var e = _publicKey.Value;
    var encryptedText = BigInteger.One;

    while (e > 0)
    {
      encryptedText *= message;
      encryptedText %= _n.Value;
      e -= 1;
    }

    return encryptedText;
  }

  // метод расшифровки
  private static BigInteger s_decrypt(BigInteger encryptedText)
  {
    var d = _privateKey.Value;
    var decrypted = BigInteger.One;

    while (d > 0)
    {
      decrypted *= encryptedText;
      decrypted %= _n.Value;
      d -= 1;
    }
    
    return decrypted;
  }
   
  // метод подсчёта НОДа
  private static BigInteger s_gcd(BigInteger a, BigInteger b)
  {
    while (true)
    {
      if (b == BigInteger.Zero) return a;
      var a1 = a;
      a = b;
      b = a1 % b;
    }
  }

  // метод шифрования
  private static List<BigInteger> s_encoder(string message)
  {
    var outputText = new List<BigInteger>();
    foreach (var letter in message)
      outputText.Add(s_encrypt(letter));
     
    // создание переменной файла для зашифрованного текста
    using var sw = new StreamWriter($"{Path}Out.txt");
    // добавление текста в файл
    sw.Write(string.Join("", outputText));

    return outputText;
  }

  // метод расшифровки
  private static string s_decoder(List<BigInteger> encoded)
  {
    var resultText = "";
    foreach (var num in encoded)
      resultText += (char)s_decrypt(num);
     
    // создание переменной файла для расшифрованного текста
    using var sw = new StreamWriter($"{Path}Result.txt");
    // добавление текста в файл
    sw.Write(resultText);

    return resultText;
  }
  
  /* Главный метод */ 
  public static void Main()
  {
    // определение ключа
    s_setKeys();
    // определение исходного текста
    var inputText = File.ReadAllText($"{Path}Input.txt");
    // определение шифрованного текста
    var encodedText = s_encoder(inputText);

    // вывод исходрного текста
    Console.WriteLine("Исходный текст:");
    Console.WriteLine(inputText);
    
    // Вывод зашифрованного текста    
    Console.WriteLine("\nЗакодированный текст:");
    foreach (var value in encodedText)
      Console.Write(value);

    // Вывод расшифрованного текста
    Console.WriteLine("\nРасскодированный текст:");
    Console.WriteLine(s_decoder(encodedText));
  }
}
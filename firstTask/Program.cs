﻿using System;
using System.Collections.Generic;

namespace informationSecurity
{
  internal abstract class Program
  {
    public static void Main(string[] args)
    {
      Dictionary<char, string> alphabet = new Dictionary<char, string>()
      {
        {'А', "ме"}, {'Б', "ли"}, {'В', "ко"}, {'Г', "ин"}, {'Д', "зе"},
        {'Е', "жу"}, {'Ж', "ню"}, {'З', "ою"}, {'И', "пы"}, {'К', "ра"},
        {'Л', "су"}, {'М', "ти"}, {'Н', "у"},  {'О', "хи"}, {'П', "от"},
        {'Р', "ца"}, {'С', "чу"}, {'Т', "ше"}, {'У', "ам"}, {'Ф', "ик"},
        {'Х', "ъ"},  {'Ц', "то"}, {'Ч', "ь"},  {'Ш', "ю"},  {'Щ', "я"},
        {'Ъ', "ф"},  {'Ы', "а"},  {'Ь', "бе"}, {'Э', "за"}, {'Ю', "гу"},
        {'Я', "ди"}
      };
    }
  }
}
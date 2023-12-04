Вариант 8
# ЗАДАНИЯ ДЛЯ ПРОГРАММАМ
# Задание 1
Контрольные задания
Осуществить кодирование методом замены русскоязычного текста, 
соблюдая при этом следующие правила:
1) кодированию подлежит только буквы русского алфавита (все знаки 
препинания игнорируются);
2) буква «ё» русского алфавита заменяется на букву «е»:
3) закодированный текст должен быть в верхнем регистре, расшифрованный в нижнем.
Разработать программу, осуществляющую кодирование методом замены входного текста (кодировщик) и отдельно программу, осуществляющую раскодирование текста (декодировщик). При написании программ осуществить файловый ввод-вывод информации.
Исходный текст должен быть в файле «Input.txt».
Закодированный текст должен быть в файле «Out.txt».
Раскодированный текст должен быть в файле «Result.txt».
Ключ (шифр) должен быть в файле «Key.txt» (при необходимости).

Напишите программы шифрования и расшифровки с использованием «цифирной азбуки». В госархиве сохранились письма Петра 
I, в которых он передавал цифири различным деятелям для корреспонденции (П. А. Толстому, А. Д. Меньшикову, …). Цифирь –
это шифр простой замены, в котором буквам сообщения соответствовали шифрообозначения, представляющие собой буквы, слоги, слова или другие какие-нибудь знаки. При этом использовались и «пустышки» – шифрообозначения, которым не соответствовали никакие знаки открытого текста.

А-ме Б-ли В-ко Г-ин Д-зе Е-жу Ж-ню З-ою И-пы К-ра
Л-су М-ти Н-у О-хи П-от Р-ца С-чу Т-ше У-ам Ф-ик
Х-ъ Ц-то Ч-ь Ш-ю Щ-я Ъ-ф Ы-а Ь-бе Э-за Ю-гу
Я-ди -

P.S.: данное задание сформулированно с коллизиями. Символы шифрования или сочетания символов шифрования не должны повторяться. 

# Задание 2
1. Разработать программу, позволяющую исследовать частотность символов открытого теста, расположенного в текстовом файле.
3. Получить от преподавателя текстовый файл, содержащий большой художественный текст на русском языке в открытом виде.
4. С помощью программы исследуйте частотность символов открытого теста.
5. Внести полученную статистику в отчет по лабораторной работе.
6. Получить от преподавателя текстовый файл, содержащий
большой объем зашифрованного текста на русском языке.
7. Исследовать частотность зашифрованного текста и внести ее в
отчет в виде, аналогичном пункту 4.
8. Сравнивая реальную частотность символов русского языка, полученную в пункте 2, с частотностями зашифрованного текста, составить
таблицу замен алгоритма шифрования и расшифровать зашифрованный текст. Таблицу замен представить в отчете.
9. Реализовать программу дешифровки заданного текста.
10. Используя программу дешифровки, расшифровать текст и представить результат работы программы в виде текстового файла.
11. Выяснить, с помощью какого метода был зашифрован файл и сделать вывод о работе.

# Задание 3
Осуществить кодирование методом перестановки русскоязычного
текста, соблюдая при этом следующие правила: в качестве блока использовать матрицу размером 6×6.

Написать исходный текст задом наперед и одновременно разбить
шифрограмму по шесть букв.

# Задание 4
Зашифровать текст методом, при котором зашифрованный символ получается по формуле: c[i] = (a[i] ≡ b[i]) mod 32, где a[i] – это
очередной символ входного текста, b[i] – очередной символ ключа (гаммы), а ≡ – логическая операция эквивалентность. При этом
при достижении последнего символа ключа (гаммы), ключ (гамма) начинается считываться опять с первого символа, т.е. ключ
(гамма) дублируется по всей длине входного текста. 

# Задание 5
Разработать программу, осуществляющую кодирование алгоритмом
RSA (кодирование с открытым ключом) входного текста (кодировщик) и отдельно программу, осуществляющую раскодирование текста (декодировщик). При написании программ осуществить файловый ввод-вывод информации.

P = 2039;
Q = 4001.

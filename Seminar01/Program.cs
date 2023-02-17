/*
Напишите программу, которая на вход принимает число и выводит квадрат этого числа.
3 -> 9
-5 -> 25
-7 -> 49
*/

Console.WriteLine("Программа вход принимает число и выводит квадрат этого числа.");

Console.WriteLine("Введите два целых числа через Enter");
Console.Write("Число = ");
int num = Int32.Parse(Console.ReadLine()!);
Console.WriteLine("Квадрат числа " + num + " является = " + num * num);

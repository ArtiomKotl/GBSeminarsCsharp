/*
Напишите программу, которая выводит название дня недели по введённому номеру
3 - Среда
5 - Пятница
*/

Console.WriteLine("Программа показывает название дня недели на русском языке по введённому номеру");
Console.Write("Введите одно целое число от 1 до 7 = ");
int numDay = Int32.Parse(Console.ReadLine()!);

switch (numDay)
{
    case 1: 
        Console.WriteLine("Понедельник");
        break;
    case 2: 
        Console.WriteLine("Вторник");
        break;
    case 3: 
        Console.WriteLine("Среда");
        break;
    case 4: 
        Console.WriteLine("Четверг");
        break;
    case 5: 
        Console.WriteLine("Пятница");
        break;
    case 6: 
        Console.WriteLine("Суббота");
        break;
    case 7: 
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Такого дня не существует.");
        break;
}
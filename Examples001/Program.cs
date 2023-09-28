//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

using System.IO.Compression;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int n = Prompt("Введите трёзначное число = ");
if (n < 100 || n >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста, повторите ввод!");
    return;
}
Console.WriteLine($"Вы ввели число: {n}");
int a = n / 10 % 10;
Console.WriteLine($"Вторая цифра введеного числа: {a}");
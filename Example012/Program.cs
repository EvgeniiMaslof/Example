// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введит трехзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = (number1 % 100) / 10;
Console.Write($"Вторая цифра: {number2}");
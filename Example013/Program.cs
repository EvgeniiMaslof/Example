// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введит число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 99)
{
    Console.Write("Третьей цифры нет");
}
else if (number1 < 999)
{
    number1 = (number1 % 10);
    Console.Write($"Третья цифра: {number1}");
}
else if (number1 < 9999)
{
number1 = (number1 / 10) % 10;
    Console.Write($"Третья цифра: {number1}");
}
else
{
    number1 = (number1 / 100) % 10;
    Console.Write($"Третья цифра: {number1}");
} 
Console.Write("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber>secondnumber)
 { 
    Console.WriteLine($"Максимальное значение: {firstnumber}");
    Console.WriteLine($"Минимальное значение: {secondnumber}");
 }
else
{
    Console.WriteLine($"Максимальное значение: {secondnumber}");
    Console.WriteLine($"Минимальное значение: {firstnumber}");
}

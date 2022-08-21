
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a > 9999)&&(a < 99999))
{
    if (a / 10000 == a % 10)
    {
        if (a / 1000 % 10 == a / 10 % 10);
        {
            Console.WriteLine("Является палиндромом!");
        }
    }
    else 
    {
        Console.Write("Не является палиндромом!");
    }
}
else
{
    Console.WriteLine("Не является пятизначным числом!");
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void СreatingAnArrayOfRealNumbers(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           arr[i,j] = new Random().Next(-100,100) + Math.Round(new Random().NextDouble(),2);
           Console.Write($"{arr [i,j]} ");
       }
       Console.WriteLine("");
    }
}

Console.Write("Введите количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [i,j];
СreatingAnArrayOfRealNumbers(arr);

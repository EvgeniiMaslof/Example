// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
void CreatesaTwoDimensionalArray( [,] array) // Создает двумерный массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(1,10);
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
  }
}
void Print()
void ArithmeticMeanOfArrayColumns(int [,] array)  //Cреднеарифметическое столбцов массива
{
  double sum = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      sum = (sum + array[i,j]); 
    }
    sum = sum / array.GetLength(0);
    Console.Write($"{Math.Round(sum, 1)} ");
    sum = 0;
  }
}

Console.Write("Задайте количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [i,j];
CreatesaTwoDimensionalArray(array);
ArithmeticMeanOfArrayColumns(array);
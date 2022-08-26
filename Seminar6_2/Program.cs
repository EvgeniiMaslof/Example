// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
void CreatesaTwoDimensionalArray(int [,] array) // Создает двумерный массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(-100,100);
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
  }
}

void SearchingForANumberInAnArrayByIndex(int [,] array) //Поиск числа в массиве по индексу
{
  Console.Write("Задайте индекс строки: ");
  int rowIndex = Convert.ToInt32(Console.ReadLine());
  Console.Write("Задайте количество столбцов: ");
  int columnIndex = Convert.ToInt32(Console.ReadLine());
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(i == rowIndex && j == columnIndex) Console.WriteLine($"{array[i,j]}");
    }
  }  
  Console.WriteLine("В заданном массиве такого элемента нет!");
}

Console.Write("Задайте количество строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [i,j];
CreatesaTwoDimensionalArray(array);
SearchingForANumberInAnArrayByIndex(array);


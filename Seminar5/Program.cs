// // 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

Console.Clear();
void arrayRandom(int [] array)
{
   for (int i = 0; i < array.Length; i++)
   {
       array[i] = new Random().Next(100,1000);
       Console.Write($"{array[i]} ");
   }
}

void arrayChet(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
      if (array[i]% 2 == 0) sum++;
    }
    Console.WriteLine($"Количество четных чисел: {sum}");
}

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
arrayRandom(array);
arrayChet(array);
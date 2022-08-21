// 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void arrayRandom(int [] array)
{
    int i = 0;
   for(int length = array.Length; i < array.Length; i++);
    {
       array[i] = new Random().Next(0,10);
       Console.Write($"{array[i]} ");
    }
}

// int arrayChet(int[] array, int sum)
// {
//     int i = 0;
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++);
//     {
//         if (array[i]% 2 == 0); sum++;
//     }
//     return Console.Write($"Количество четных чисел: {sum}");
// }

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
arrayRandom(array);
// arrayChet(array);
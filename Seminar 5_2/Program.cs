// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
void random(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(-99,99);
       Console.Write($"{arr [i]} ");
    }
    Console.WriteLine("");
}

void sumNechet(int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length;)
    {
        sum = sum + arr[i];
        i = i + 2;
    }
    Console.WriteLine($"Сумму чисел на нечетных позициях: {sum}");
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [length];
random(arr);
sumNechet(arr);
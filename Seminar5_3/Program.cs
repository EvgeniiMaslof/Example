// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
void random(double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(-100,100) + Math.Round(new Random().NextDouble(),2);
       Console.Write($"{arr [i]} ");
    }
    Console.WriteLine("");
}

void MaxMin(double [] arr)
{
    double max = arr[0];
    double min = arr[0];
    double diff = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])  max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    diff = max - min;
    Console.Write($"максимум: {max} ");
    Console.Write($"минимум: {min} ");
    Console.WriteLine($"Разница между максимумом и минимумом: {Math.Round(diff,2)}");
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] arr = new double [length];
random(arr);
MaxMin(arr);
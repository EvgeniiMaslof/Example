// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// Console.Clear();
// Console.Clear();
// void CreatesaTwoDimensionalArray(string [] array) // Создает массив строк
// {
//   Console.WriteLine("Введите значение строки: ");
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     array[i] = Convert.ToString(Console.ReadLine());
//   }
// }
// void PrintArray(string [] array)  // Печатает массив
// {
//     Console.Write("[");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if(array[i]!= "") Console.Write(array[i]  + " ");
//     }
//     Console.Write("]");
// }
// void Createsa(string [] array, string [] array2) // Создает массив из элементов состоящих их 3 символов
// {
//   int j = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (array[i].Length <= 3)
//     {
//         array2[j] = array[i];
//         j++;
//     }
//   }
// }

// Console.Write("Задайте количество строк: ");
// int length = Convert.ToInt32(Console.ReadLine());
// string[] array = new string [length];
// CreatesaTwoDimensionalArray(array);
// PrintArray(array);
// Console.Write(" - ");
// string[] array2 = new string [length];
// Createsa(array, array2);
// PrintArray(array2);

// Console.Clear();
// void CreatesaTwoDimensionalArray(string [] array) // Создает массив строк
// {
//   Console.WriteLine("Введите значение строки: ");
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     array[i] = Convert.ToString(Console.ReadLine());
//   }
// }
// void PrintArray(string [] array)  // Печатает массив
// {
//     Console.Write("[");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if(array[i]!= "") Console.Write(array[i]  + " ");
//     }
//     Console.Write("]");
// }
// void Createsa(string [] array, string [] array2) // Создает массив из элементов состоящих их 3 символов
// {
//   int j = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     if (array[i].Length <= 3)
//     {
//         array2[j] = array[i];
//         j++;
//     }
//   }
// }
Console.Clear();
Console.Write("Задайте количество строк: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string [length];
Console.WriteLine("Введите значение строки: ");
int j = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
    if(array[i].Length <= 3) j++;
}
Console.Write("[");
for (int i = 0; i < array.GetLength(0); i++)
{
   Console.Write(array[i] + " ");
}
Console.Write("] - ");
string[] array2 = new string [j];
j = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        j++;
    }
}
Console.Write("[");
for (int i = 0; i < array2.GetLength(0); i++)
{
   Console.Write(array2[i] + " ");
}
Console.Write("]");
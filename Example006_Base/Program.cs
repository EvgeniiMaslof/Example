Console.Write("Вес первой гири: ");
double weights1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Вес второй гири: ");
double weights2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Вес третьей гири: ");
double weights3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Вес четвертой гири: ");
double weights4 = Convert.ToDouble(Console.ReadLine());
Console.Write("Вес пятой гири: ");
double weights5 = Convert.ToDouble(Console.ReadLine());

double max = weights1;

if (weights1 > max) max = weights1;
if (weights2 > max) max = weights2;
if (weights3 > max) max = weights3;
if (weights4 > max) max = weights4;
if (weights5 > max) max = weights5;
Console.WriteLine(max);
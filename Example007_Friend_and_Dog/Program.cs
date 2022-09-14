Console.Write("Введите скорость первого друга: ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
double DogSpeed = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите расстояние между друзьями: ");
double distance = Convert.ToDouble(Console.ReadLine());

int count = 0;
int friend = 2;
double time = 0;

while (distance > 5)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else 
    {
        time = distance / (secondFriendSpeed + DogSpeed);
        friend = 1;
    } 
   distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
   count = count + 1;
}
Console.Write("Собака пробежит раз: ");
Console.WriteLine(count);

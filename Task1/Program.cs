Console.Write("Введите число 1: ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

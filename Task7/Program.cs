Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Это не трёхзначное число!");
}
else {
    int result = number % 10;
    Console.WriteLine("Последняя цифра Вашего числа: " + result);
}

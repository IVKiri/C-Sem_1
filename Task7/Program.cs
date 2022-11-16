Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine("Последняя цифра Вашего числа: " + result);

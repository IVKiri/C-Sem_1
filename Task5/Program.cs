Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
double x1 = -number;

while(x1 < number)
{
    Console.Write(x1 + ", ");
    x1 = x1+1;
}
Console.Write(number);

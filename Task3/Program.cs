// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели от 1 до 7: ");
int daynum = Convert.ToInt32(Console.ReadLine());

if (daynum == 1)
{
    Console.WriteLine("Понедельник");
}
if (daynum == 2)
{
    Console.WriteLine("Вторник");
}
if (daynum == 3)
{
    Console.WriteLine("Среда");
}
if (daynum == 4)
{
    Console.WriteLine("Четверг");
}
if (daynum == 5)
{
    Console.WriteLine("Пятница");
}
if (daynum == 6)
{
    Console.WriteLine("Суббота");
}
if (daynum == 7)
{
    Console.WriteLine("Воскресенье");
}
if (daynum > 7)
{
    Console.WriteLine("Число должно быть от 1 до 7");
}


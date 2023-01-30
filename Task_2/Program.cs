Console.Clear();

Console.WriteLine("Введите 2 числа");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Является ли {a} квадратом числа {b}");

if ((b*b) == a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
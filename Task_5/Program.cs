// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int temp = number;

if (number > 999)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else if (number < 100)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else
{
while(temp >= 100)
{
    temp = temp - 100;
    while(temp >= 10)
    {
        temp = temp - 10;
    }
}
}
Console.WriteLine($"Последняя цифра числа {number} это {temp}");

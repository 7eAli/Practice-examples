// Определить количество цифр в числе
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int counter = 0;
if (num == 0) counter = 1;
else
{
    while (num != 0)
    {
        num /= 10;
        counter++;
    }
}
Console.WriteLine($"В числе {counter} цифр");

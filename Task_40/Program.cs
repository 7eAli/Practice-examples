// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int NumberToPower(int number, int power)
{
    if (power == 0) return 1;
    else
    {
        return number * NumberToPower(number, power - 1);
    }
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int power = int.Parse(Console.ReadLine()!);

int result = NumberToPower(number, power);
Console.WriteLine($"{number} в степени {power} равно {result}");
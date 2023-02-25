// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

int DigitSum(int number)
{
    if (number == 0) return 0;
    else
    {        
        return number % 10 + DigitSum(number / 10);
    }
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int digSum = DigitSum(number);
Console.WriteLine($"Сумма чисел у {number} равна {digSum}");
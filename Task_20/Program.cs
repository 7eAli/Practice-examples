// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

bool FindNumber(int number, int[] inArray)
{   
    foreach(int element in inArray)
    {
        if (element == number) return true;
    }
    return false;
}

Console.Clear();

int[] array = GetArray(10, -9, 9);
Console.WriteLine(string.Join(", ", array));
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
// bool check = FindNumber(number, array);
if (FindNumber(number, array) == true) Console.WriteLine("Да");
else Console.WriteLine("Нет");

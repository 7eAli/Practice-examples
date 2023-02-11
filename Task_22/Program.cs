﻿// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] ProdArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];            
        }
    if (array.Length % 2 == 1)
    {
        result[size - 1] = array[array.Length / 2];
    }
    return result;
}

Console.Clear();

int[] array = GetArray(5, 1, 10);
Console.WriteLine(string.Join(", ", array));
int[] prodArray = ProdArray(array);
Console.WriteLine(string.Join(", ", prodArray));
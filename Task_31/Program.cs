﻿/* Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали (с
индексами (0,0); (1;1) и т.д. */

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
             {
                sum += array[i, j];
             }
        }
    }
    return sum;
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, column, -10, 10);
PrintArray(array);
Console.WriteLine($"Сумма элементов на главной диагонали = {SumDiagonal(array)}");
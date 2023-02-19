/* Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. */

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

int[] FindMinimum(int[,] array)
{
    int min = array[0, 0];
    int[] minPosition = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minPosition[0] = i;
                minPosition[1] = j;
            }
        }
    }
    return minPosition;
}

int[,] DeleteMinColumnsAndRows(int[,] array, int[] minPosition)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minPosition[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != minPosition[1])
            {
                result[row, column] = array[i, j];
                column++;
            }
        }
        column = 0;
        row++;
    }
    return result;
}

Console.Clear();

Console.Clear();
Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение в массиве: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение в массиве: ");
int max = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, column, min, max);

PrintArray(array);
int[] minPosition = FindMinimum(array);
int[,] newArray = DeleteMinColumnsAndRows(array, minPosition);
Console.WriteLine();
PrintArray(newArray);
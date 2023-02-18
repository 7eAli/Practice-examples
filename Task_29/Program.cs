/* Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aij = i+j. 
Выведите полученный массив на экран. */

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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

Console.Clear();

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine()!);

int[,] array = GetArray(row, column);
PrintArray(array);

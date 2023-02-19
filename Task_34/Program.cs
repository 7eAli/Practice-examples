/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

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

int[] Convert2DimTo1Dim(int[,] array)
{
    int[] newArray = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[k] = array[i, j];
            k++;
        }
    }
    return newArray;
}

void SortArray(int[] array)
{
    int swap;
    bool check = false;
    while (check == false)
    {
        check = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                check = false;
                swap = array[i];
                array[i] = array[i + 1];
                array[i + 1] = swap;
            }
        }
    }
}

void CountElements(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"В массиве {count} чисел {array[i - 1]}");
            count = 1;
        }
    }
    Console.WriteLine($"В массиве {count} чисел {array[array.Length - 1]}");    
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
Console.WriteLine();

int[] newArray = Convert2DimTo1Dim(array);
SortArray(newArray);
CountElements(newArray);
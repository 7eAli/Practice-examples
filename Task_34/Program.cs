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
            if (count == 1) Console.WriteLine($"Число {array[i - 1]} встречается {count} раз");
            else Console.WriteLine($"Число {array[i - 1]} встречается {count} раза");
            count = 1;
        }
    }
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
Console.WriteLine(string.Join(", ", newArray));
SortArray(newArray);
Console.WriteLine(string.Join(", ", newArray));
CountElements(newArray);

// /* Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/
// Console.Clear();
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }
// int[] convert2DTo1D(int[,] inArray)
// {
//     int[] convert = new int[inArray.GetLength(0) * inArray.GetLength(1)];
//     int k = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             convert[k++] = inArray[i, j];
//         }
//     }
//     return convert;
// }
// void sortConvert(int[] inArray)
// {
//     int temp;
//     for (int i = 0; i < inArray.Length - 1; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 temp = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = temp;
//             }
//         }
//     }
// }
// void countResult(int[] inArray)
// {
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] == inArray[i - 1])
//         {
//             count++;
//         }
//         else
//         {
//             Console.WriteLine($"Количество {inArray[i - 1]} встречается {count} раз");
//             count = 1;
//         }
//     }
//     Console.WriteLine($"Количество {inArray[inArray.Length-1]} встречается {count} раз");
// }
// Console.Write("Введите кол-во строк: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.Write("Введите кол-во столбцов: ");
// int col = int.Parse(Console.ReadLine()!);
// int[,] array2D = GetArray(row, col, 0, 3);
// PrintArray(array2D);
// int[] convert = convert2DTo1D(array2D);
// sortConvert(convert);
// countResult(convert);
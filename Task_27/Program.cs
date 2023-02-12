// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] CopyArray(int[] array)
{
     int[] result = new int[array.Length];
     for (int i = 0; i < array.Length; i++)
     {
        result[i] = array[i];
     }
     return result;
}

Console.Clear();

int[] arrayOne = GetArray(10, 0, 10);
Console.WriteLine(string.Join(", ", arrayOne));
int[] arrayTwo = CopyArray(arrayOne);
Console.WriteLine();
Console.WriteLine(string.Join(", ", arrayTwo));


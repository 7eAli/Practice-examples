// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int FindAmount(int[] inArray)
{
    int amount = 0;
    // for (int i = 0; i < inArray.Length; i++)
    // {
    //     if (inArray[i] > 9 && inArray[i] < 100)
    //     {
    //         amount += 1;
    //     }
    // }
    foreach(int element in inArray)
    {
        if (element > 9 && element < 100)
        {
            amount++;
        }
    }
    return amount;
}

Console.Clear();

int[] array = GetArray(10, -100, 100);
Console.WriteLine(string.Join(", ", array));
int amount = FindAmount(array);
Console.WriteLine(amount);
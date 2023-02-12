// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void FlipArray1(int[] array) // Подходит для изменения массива
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] FlipArray2(int[] array) // Подходит для создания нового массива, противоположного исходному, без его изменения
{
    int [] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

int[] array = GetArray(7, 0, 10);
Console.WriteLine(string.Join(", ", array));
FlipArray1(array);
Console.WriteLine(string.Join(", ", array));
int[] reversed = FlipArray2(array);
Console.WriteLine(string.Join(", ", reversed));
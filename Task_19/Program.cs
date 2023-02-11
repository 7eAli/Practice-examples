// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void ChangeSign(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        //inArray[i] = -inArray[i];
        inArray[i] *= -1;
    }        
}

Console.Clear();
int[] array = GetArray(10, -9, 9);
Console.WriteLine(string.Join(", ", array));
ChangeSign(array);
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
// }

Console.WriteLine(string.Join(", ", array));
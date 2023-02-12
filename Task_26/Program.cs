// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// int Fibonacci(int n)
// {
//     int elemOne = 0;
//     int elemTwo = 1;
//     int result = elemOne + elemTwo;
//     for (int i = 3; i <= n; i++)
//     {
//         elemOne = elemTwo;
//         elemTwo = result;
//         result = elemOne + elemTwo;
//     }
//     return result;
// }

// Console.Clear();
// for (int i = 2; i < 50; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

double[] Fibonacci(int N)
{
    double[] array = new double[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.Clear();

Console.Write("Сколько чисел Фибоначи вывести? ");
int N = int.Parse(Console.ReadLine()!);
double[] array = Fibonacci(N);
Console.WriteLine(string.Join(", ", array));
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

string NumbersList(int N)
{
    if (N == 1) return N.ToString();
    else
    {        
        return NumbersList(N - 1) + ", " + N.ToString();
    }
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine()!);
string list = NumbersList(N);
Console.WriteLine(list);

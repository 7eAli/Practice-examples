// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N

string NumbersList(int N, int M)
{
    if (N == M) return N.ToString();
    else if (M > N)
    {
        return NumbersList(N, M - 1) + ", " + M.ToString();
    }
    else
    {        
        return NumbersList(N - 1, M) + ", " + N.ToString();
    }
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine()!);
string list = NumbersList(N, M);
Console.WriteLine(list);
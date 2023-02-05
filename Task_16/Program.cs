/* Возведите число А в натуральную степень B используя цикл */

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("В какую степень возвести число?: ");
int b = int.Parse(Console.ReadLine()!);
double result = a;
if(b > 0)
{
for (int i = 1; i < b; i++)
{
    result = result * a;
}
}
else if (b < 0)
{
    b = -b;
    for (int i = 1; i < b; i++)
{
    result = result * a;
}
result = 1/result;
}
else result = 1;
Console.WriteLine(result);

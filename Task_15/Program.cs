/* Найти сумму чисел от 1 до A */

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;
if (num > 0)
{
for (int i = 0; i <= num; i++)
{
    sum = sum + i;
}
}
else
{
   for (int i = 0; i >= num; i--)
   {
    sum = sum + i;
   } 
}
Console.WriteLine(sum);
// // Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 0) num = -num;
int check = 1;

// while(check <= num)
// {
//     Console.Write($"{Math.Pow(check, 2)} ");
//     if (check != a)
//     {
//         Console.Write(", ");
//     }   
//     check += 1;
// }

while(check <= num)
{
    Console.Write($"{check * check} ");
    if (check != num)
    {
        Console.Write(", ");
    }
    check += 1;
}


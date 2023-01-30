// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int ost7 = num % 7;
int ost23 = num% 23;

if (ost7 == 0 && ost23 == 0) Console.WriteLine($"Число {num} кратно 7 и 23");
else Console.WriteLine($"Число {num} не кратно 7 и 23");

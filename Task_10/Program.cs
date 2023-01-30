//Напишите программу, которая принимает на вход два
//числа и проверяет, является ли одно число квадратом
//другого.

Console.Clear();

Console.WriteLine("Введите 2 числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2 * num2) Console.WriteLine($"Число {num1} является квадратом числа {num2}");
else if (num2 == num1 * num1) Console.WriteLine($"Число {num2} является квадратом числа {num1}");
else Console.WriteLine("Не является");
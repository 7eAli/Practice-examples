// Напишите программу, которая будет принимать на вход два числа и выводит, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления

Console.Clear();

Console.WriteLine("Введите 2 числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0) Console.WriteLine($"Число {num1} кратно числу {num2}");
else Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток от деления равен {num1 % num2}");
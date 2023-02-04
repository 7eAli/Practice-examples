Console.Clear();

int condition = 0;

while (condition == 0)
{
Console.Write("Введите номер дня недели: ");
int week = int.Parse(Console.ReadLine()!);
if (week == 1)
{
    Console.WriteLine("Понедельник");
}

else if (week == 2)
{
    Console.WriteLine("Вторник");
}

else if (week == 3)
{
    Console.WriteLine("Среда");
}

else if (week == 4)
{
    Console.WriteLine("Четверг");
}

else if (week == 5)
{
    Console.WriteLine("Пятница");
}

else if (week == 6)
{
    Console.WriteLine("Суббота");
}

else if (week == 7)
{
    Console.WriteLine("Воскресенье");
}

else
{
    Console.WriteLine("Ошибка");
}
Console.Write("Для выхода из программы нажмите любую клавишу, для продолжения нажмите 0: ");
condition = int.Parse(Console.ReadLine()!);
}

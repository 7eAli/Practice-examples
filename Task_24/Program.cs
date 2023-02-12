// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

bool TriangleCheck(int a, int b, int c)
{
    // if(a + b >  c && a + c > b && c + b > a) return true;
    // else return false;
    return a + b > c && a + c > b && c + b > a;
}

Console.Clear();

int a = new Random().Next(1, 20);
int b = new Random().Next(1, 20);
int c = new Random().Next(1, 20);
Console.WriteLine($"Отрезки: {a}, {b}, {c}");
if (TriangleCheck(a, b, c) == true) Console.WriteLine("Можно составить треугольник");
else Console.WriteLine("Нельзя составить треугольник");

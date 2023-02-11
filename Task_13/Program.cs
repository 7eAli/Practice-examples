// Задание 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
Console.Clear();
Console.Write("Введите Xa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите Ya: ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите Xb: ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите Yb: ");
int Yb = int.Parse(Console.ReadLine()!);

double distance = Math.Round(Math.Sqrt((Xa - Xb)*(Xa - Xb) + (Ya - Yb)*(Ya - Yb)), 2);
//distance = Math.Round(distance, 2);
Console.WriteLine($"Расстояние между точками a и b равно {distance}");

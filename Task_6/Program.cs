﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Clear();

int num = new Random().Next(10,100);
// 123 / 10 = 12 при int; 123 % 10 = 3
int a1 = num / 10;
int a2 = num % 10;

if (a1 > a2)
{
    Console.Write($"Максимальное числа {num} = {a1}");
}
else
{
    Console.Write($"Максимальное числа {num} = {a2}");
}
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Console.Clear();

int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int a1 = num / 100;
int a3 = num % 10;

a1 = a1* 10;
num = a1 + a3;

Console.WriteLine(num);
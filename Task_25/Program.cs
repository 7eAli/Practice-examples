// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

string ConverDecToBin(int num)
{
    string result = "";
    while(num > 0)
    {
        result = (num % 2).ToString() + result;
        num /= 2;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
string binNum = ConverDecToBin(num);
Console.WriteLine(binNum);
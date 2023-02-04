// // Задание 18. Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

// if (num < 1 || num > 4)
// {
//     Console.WriteLine("Вы опечатались");
// }
// else if (num == 1)
// {
//     Console.WriteLine("X > 0; Y > 0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("X < 0; Y > 0");
// }
// else if (num == 3)
// {  
//     Console.WriteLine("X < 0; Y < 0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("X > 0; Y < 0");    
// }
// else
// {
//     Console.WriteLine("Вы опечатались");
// }
// if (num > 0 && num < 5)
// {
//     if (num == 1 || num == 4)
//     {
//         Console.Write("X > 0; ");   
//     }
//     else Console.Write("X < 0; ");
//     if (num == 1 || num == 2)
//     {
//         Console.Write("Y > 0");   
//     }
//     else Console.Write("Y < 0"); 
// }
// else
// {
//     Console.WriteLine("Вы опечатались");
// }
switch (num)
{
    case 1:
        Console.WriteLine("X > 0; Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0; Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0; Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0; Y < 0");
        break;
    default:
        Console.WriteLine("Вы опечатались");
        break;        
}

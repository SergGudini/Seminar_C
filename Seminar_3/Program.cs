// Задача 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*Console.WriteLine("Введите номер четверти от 1 до 4");
int part = Convert.ToInt32(Console.ReadLine());

if (part >= 1 && part <= 4)
{
    if (part == 1)
    {
        Console.WriteLine("x > 0 y > 0");
    }
    else if (part == 2)
    {
        Console.WriteLine("x < 0 y > 0");
    }
    else if (part == 3)
    {
        Console.WriteLine("x < 0 y < 0");
    }
    else if (part == 4)
    {
        Console.WriteLine("x > 0 y < 0");
    }
}
else Console.WriteLine("Номер четверти не подходит");*/

/*Console.Write("Введите координаты: ");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
        Console.WriteLine("x > 0 y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0 y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0 y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0 y < 0");
        break;
   default:
        Console.WriteLine("Номер четверти не подходит");
        break;
}*/

// Задача 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

/*Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
Console.Write($"Расстояние: {Math.Round(result,3)}");*/

// ЦИКЛЫ for и while

// while (условие) {...}
int i = 1;
while(i <= 10)
{
    Console.WriteLine("Hello");
    i++;
}
// for (int i = 1; i <= 5; i++) {...}
for (int j = 1; j <= 5; j++)
{
    Console.WriteLine("Hello");
}

// Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) // если число положительное
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i,3)} "); //возведение в степень 3
    }
}
else if (number < 0) // если число отрицательное
{
    for (int i = number; i <= 1; i++)
    {
        Console.Write($"{Math.Pow(i,3)} ");
    }
}
else Console.Write("Вы ввели некорректное число");


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Ввод данных 
Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
int i = 1;

// Поиск четных чисел от 1 до chislo
while(i <= chislo)
{
    if ((i % 2) == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

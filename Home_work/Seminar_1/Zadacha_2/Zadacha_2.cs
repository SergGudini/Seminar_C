// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// Ввод данных
Console.Write("Введите первое число: ");
int chislo_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int chislo_2 = Convert.ToInt32(Console.ReadLine());

// Поиск наименьшего и наибольшего числа
if (chislo_1 > chislo_2)
{
    Console.WriteLine($"Наибольшее число: {chislo_1}");
    Console.WriteLine($"Наименьшее число: {chislo_2}");
}
else 
{
    Console.WriteLine($"Наибольшее число: {chislo_2}");
    Console.WriteLine($"Наименьшее число: {chislo_1}");
}


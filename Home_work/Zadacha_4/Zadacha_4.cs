// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел. 

// Объявляем массив
int[] chisla = new int[3];
int i = 0;

// Заполнение массива
Console.WriteLine("Введите числа");
while(i < 3)
{
    chisla[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

// Поиск максимального
int max = chisla[0];
i = 1;
while(i < chisla.Length)
{
    if(chisla[i] > max)
    {
        max = chisla[i];
    }
    i++;
}

//Вывод
Console.WriteLine($"Максимальное число: {max}");

//Второй вариант нахождения максимального
max = chisla.Max();
Console.WriteLine($"Максимальное число: {max}");

// See https://aka.ms/new-console-template for more information

/*int[] GetRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(left, right+1);
    }

    return array;
}

int[] massive = GetRandomArray(12, -9, 9);
Console.WriteLine(string.Join(", ", massive)); //быстрый вывод массива через строковый формат*/

//Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

/*int[] GetRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(left, right+1);
    }

    return array;
}

int size = 10;
int left = -9;
int right = 9;

int[] massive = GetRandomArray(size, left, right);
Console.WriteLine(string.Join(", ", massive));

for (int i = 0; i < size; i++)
{ 
    massive[i] = massive[i] * (-1);
}

Console.WriteLine(string.Join(", ", massive));*/

//Задача 33: Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.

int[] GetRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(left, right+1);
    }

    return array;
}

int size = 10;
int left = -9;
int right = 9;

int[] massive = GetRandomArray(size, left, right);
Console.WriteLine(string.Join(", ", massive));

Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

int enter = 0;

for (int i = 0; i < size; i++)
{
    if (massive[i] == chislo)
    {
        Console.WriteLine("Да");
        enter = 1;
        break;
    }
}

if (enter == 0) Console.WriteLine("Нет");

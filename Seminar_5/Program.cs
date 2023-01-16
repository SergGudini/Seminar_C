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

if (enter == 0) Console.WriteLine("Нет");*/

// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*int[] GetRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(left, right+1);
    }

    return array;
}

int size = 123;
int left = 0;
int right = 150;

int[] massive = GetRandomArray(size, left, right);
//Console.WriteLine(string.Join(", ", massive));

int[] etalon = new int[90];
    for(int i = 0; i < 90; i++)
    {
        etalon[i] = new Random().Next(10, 99);
    }

int kolichestvo = 0; 

for(int i = 0; i < size; i++)
{

}*/


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] GetRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(left, right+1);
    }

    return array;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int left = -9;
int right = 9;

int[] massive = GetRandomArray(size, left, right);
Console.WriteLine(string.Join(", ", massive));

int SizeNew = 0;

if (size % 2 == 0)
{
    SizeNew = size / 2;
    int[] ResultArray = new int[SizeNew];
    for(int i = 0; i < SizeNew; i++)
    {
        ResultArray[i] = massive[i] * massive[size - i - 1];
    }
    Console.WriteLine(string.Join(", ", ResultArray));
}
else if (size % 2 != 0)
{
    SizeNew = (size / 2) + 1;
    int[] ResultArray = new int[SizeNew];
    int temp = massive[size/2];
    
    for(int i = 0; i < SizeNew; i++)
    {
        ResultArray[i] = massive[i] * massive[size - i - 1];
    }
    ResultArray[SizeNew - 1] = temp;
    Console.WriteLine(string.Join(", ", ResultArray));
}
else Console.WriteLine("Вы ввели неверный размер массива");





﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

int[] EnterArray(int size) // заполнение массива пользователем с консоли
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());;
    }

    return arr;
}

void ExitArray(int[] arr) // вывод массива в консоль
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Введите размер массива: "); // ввод пользователем размера массива
int size = Convert.ToInt32(Console.ReadLine());

int[] array = EnterArray(size);
ExitArray(array);

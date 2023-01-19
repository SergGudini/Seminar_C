// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] massive = GetRandomArray(size);
int index = 0;

Console.Write("Ваш массив: ");
for(int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 == 0) index++; //счетчик
    Console.Write($"{massive[i]} "); // выводит элементы массива
}

Console.WriteLine($"\nКоличество чётных чисел: {index}");
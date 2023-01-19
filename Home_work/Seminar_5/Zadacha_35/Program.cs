// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] GetRandomArray(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 151); // генератор случайных положительных чисел от 0 до 150
    }

    return array;
}

int Kolichestvo(int[] array, int number)
{
    int index = 0;
    for(int i = 0; i < number; i++)
    {
        for(int j = 10; j < 100; j++)
        {
            if(array[i] == j) index++; // счетчик чисел в диапазоне от 10 до 99
        }
    }
    return index;
}

int number = 123;
int[] array = GetRandomArray(number);

/*for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} "); // выводит элементы массива
}*/

Console.WriteLine($"\nКоличество чисел в диапазоне: {Kolichestvo(array,number)}");


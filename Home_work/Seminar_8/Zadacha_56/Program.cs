// Задача 56: Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] GetRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int MinSumRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i,j];
        }
    }

    int min = sum[0];
    int position = 0;

    for(int i = 1; i < array.GetLength(0); i++)
    {
        if (sum[i] < min) 
        {
            position = i;
            min = sum[i];
        }
    }

    return position;
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomArray(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintArray(array);

Console.WriteLine($"Наименьшая сумма элементов в строке: {MinSumRow(array) + 1}");
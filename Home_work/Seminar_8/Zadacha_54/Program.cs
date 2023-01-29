// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] UbivanieRows(int[,] array)
{
    int temp = 0;
    int max = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(0); k++)
            {
                if (array[i,j] > array[i,k])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }

    return array;
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomArray(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintArray(array);

Console.WriteLine("Матрица по убыванию");

int[,] matrix = UbivanieRows(array);
PrintArray(matrix);

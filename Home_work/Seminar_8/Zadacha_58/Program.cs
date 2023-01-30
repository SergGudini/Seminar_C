// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] TransponitionArray(int[,] array1, int[,] array2)
{
    int[,] transponition = new int[array1.GetLength(0),array2.GetLength(1)];

    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                transponition[i,j] = (array1[i,k] * array2[k,j]) + transponition[i,j];
            }
            
        }
    }

    return transponition;
}

const int ROWS = 3;
const int COLUMNS = 3;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array1 = GetRandomArray(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Первая матрица");
PrintArray(array1);

int[,] array2 = GetRandomArray(COLUMNS, ROWS, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Вторая матрица");
PrintArray(array2);

int[,] transponition = TransponitionArray(array1,array2);
Console.WriteLine("Транспонированная матрица");
PrintArray(transponition);
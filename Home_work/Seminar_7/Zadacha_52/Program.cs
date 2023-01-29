// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange + 1);
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

void ArithmeticMeanColumn(int[,] array) // расчет среднего арифметического
{
    double[] mean = new double[array.GetLength(1)];
    double sum = 0;

    Console.Write("Среднее арфиметическое: ");

    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
            mean[i] = sum / array.GetLength(0);
        }
        sum = 0;
        Console.Write($"{Math.Round(mean[i],2)} ");
    }
    
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomArray(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintArray(array);

ArithmeticMeanColumn(array);
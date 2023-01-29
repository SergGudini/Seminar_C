// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows,columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = leftRange + (new  Random().NextDouble() * (rightRange - leftRange)); // ранодмные вещественные числа с диапазоном от -9 до 9
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 2) + "  "); // округление до двух чисел после запятой
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

double[,] array = GetRandomArray(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintArray(array);

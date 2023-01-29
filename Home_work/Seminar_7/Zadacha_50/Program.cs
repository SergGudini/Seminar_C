// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void ElementFromPosition(int[] position, int[,] array)
{
    int element = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(position[0] == i && position[1] == j)
            {
                element = array[i,j];
                break;
            }
            
        }
    }

    if (element != 0) Console.WriteLine($"Ваш элемент: {element}");
    else Console.WriteLine("Такого элемента нет");
}

const int ROWS = 3;
const int COLUMNS = 5;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomArray(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintArray(array);

Console.WriteLine("Введите позицию элемента массива: ");
int[] position = new int[2];
for(int i = 0; i < position.Length; i++)
{
    position[i] = Convert.ToInt32(Console.ReadLine());
} 

ElementFromPosition(position, array); 

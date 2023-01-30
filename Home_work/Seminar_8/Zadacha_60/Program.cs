// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetRandom3Array(int rows, int columns, int z, int leftRange, int rightRange)
{
    int[,,] array = new int[rows,columns,z];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(leftRange, rightRange + 1);
            }
            
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
            
        }
        Console.WriteLine();
    }
}

const int ROWS = 2;
const int COLUMNS = 2;
const int Z = 2;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,,] array1 = GetRandom3Array(ROWS, COLUMNS, Z, LEFTRANGE, RIGHTRANGE);
Console.WriteLine("Первая матрица");
PrintArray(array1);

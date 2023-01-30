// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetRandom3Array()
{
    int[,,] array = new int[2,2,2];
    int number = 10;

    for(int i = 0; i < 2; i++)
    {   
        for(int j = 0; j < 2; j++)
        { 
            for(int k = 0; k < 2; k++)
            {
                number = number + i + j + k;
                array[i,j,k] = number;                
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
            Console.WriteLine();
        }
        
    }
}

int [,,] array1 = GetRandom3Array();
PrintArray(array1);

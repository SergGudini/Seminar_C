// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] GetRandomArray()//(int leftRange, int rightRange)
{
    int[,] array = new int[4,4];
    int number = 1;
    int size = 4;

    for(int k = 0; k < 4; k++)
    {
        for(int l = 0; l < 4; l++)
        {
            array[k,l] = 0;//new Random().Next(leftRange, rightRange + 1);
        }
    }
   
  int point = 0;
  
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i,j] = number;
                    number++;
                }
                i = size - 1;
                for (int j = 1; j < 4; j++)
                {
                    array[j,size-1] = number;
                    number++;
                }
                size--;
                for(int j = size - 1; j >= 0; j--)
                {
                    array[i,j] = number;
                    number++;
                }

                for(int j = size-1; j >= point+1; j-- )
                {
                    array[j,point] = number;
                    number++;
                }
                point++;
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

/*void PrintSpiralArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             
            Console.Write(array[i, j] + " ");
        }
        if(j == array.GetLength(1) - 1) i = 1;
        Console.WriteLine();
    }
}*/


//const int LEFTRANGE = 0;
//const int RIGHTRANGE = 9;

int[,] array1 = GetRandomArray();//(LEFTRANGE, RIGHTRANGE);

Console.WriteLine("Обычный");
PrintArray(array1);
//Console.WriteLine("По спирали");
//PrintSpiralArray(array1);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray()//(int leftRange, int rightRange)
{
    int[,] array = new int[4,4];
    int number = 1;
    
    for(int k = 0; k < 4; k++)
    {
        for(int l = 0; l < 4; l++)
        {
            array[k,l] = 0;//new Random().Next(leftRange, rightRange + 1);
        }
    }
   
    int point = 0;
    int i,j = 0;
    int size = 4;
    int temp = 0;

    while (temp != 2)
    {
        for(i = point; i < size; i++) array[j,i] = number++;
        j = i - 1;

        for(i = point + 1; i < size; i++) array[i,j] = number++;

        for(i = size - 2; i >= point; i--) array[j,i] = number++;

        j = point;
        for(i = size - 2; i > point; i--) array[i,j] = number++;

        size = size - 1;
        point++;
        j = point;
        temp++;
    }
    
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > 0 && array[i,j] < 10) Console.Write($"0{array[i,j]} ");
            else Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = SpiralArray();

PrintArray(array);

// сумму чисел от 1 до А

/*int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

int number = ReadNumber("Inter number");
int summa = GetSum(number);
Console.WriteLine($"Summa: {summa}");*/

// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе
 
/*int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Size(int number)
{
    int size = 0;
    while (number != 0)
    {
        number = number / 10;
        size ++; 
    }
    return size;
}

int number = ReadNumber("Inter number");
int length = Size(number);
Console.WriteLine($"Razmer: {length}");*/

// Задача 28: Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.

int[] EnterRandomArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,2);
    }

    return arr;
}

void ExitArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

// int[] array = EnterRandomArray(8);
// ExitArray(array);

ExitArray(EnterRandomArray(8));

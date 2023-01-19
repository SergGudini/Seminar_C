// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*int[] GetRandomArray()
{
    int[] array = new int[5];
    for(int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(1, 11);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    return array;
}

/*void ExitArray(int[] array) // вывод перевернутого массива
{
    int temp = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = array.Length - 1; j > 0; j--)
        {
            array[i] = array[j];
            break;
        }
    }
    return array;
}*/

/*GetRandomArray();

int[] array = GetRandomArray();

for (int i = 0; i < array.Length/2; i++)
{
    for (int j = array.Length - 1; j > 0; j--)
    {
        array[i] = array[j];
        break;
    }
}
for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
ExitArray(array);*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное

/*int SizeFind(int number)
{
    int size = 0;
    while(number != 0)
    {
        number /= 2;
        size++;
    }
    return size;
}

int BoolNumber(int number, int size)
{
    int[] array = new int[size];

    int index = size - 1;
    while(number != 0)
    {
        array[index] = number % 2;
        number = number / 2;
        index--;
    }
    return array;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
BoolNumber(number, SizeFind(number));*/

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.


/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 0; i < number; i++)
    {
        array[i+2] = array[i] + array[i+1];
        
    }

    for (int i = 0; i < number; i++)
    {
        Console.WriteLine(array[i]);
    }*/

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.




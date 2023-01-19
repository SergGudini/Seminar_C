// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] GetRandomArray(int size, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, right+1); // генератор случайных чисел
    }

    return array;
}

int MaxAndMin(int[] array)
{
    int min = array[0]; // присвоим начальниые значения для мин и макс
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }

    int result = max - min;
    
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите правую границу массива: ");
int right = Convert.ToInt32(Console.ReadLine());

int[] massive = GetRandomArray(size,right);

Console.Write("Ваш массив: ");
for(int i = 0; i < massive.Length; i++)
{
    Console.Write($"{massive[i]} "); // выводит элементы массива
}

Console.Write($"Разница между максимальным и минимальным элементов массива: {MaxAndMin(massive)}");

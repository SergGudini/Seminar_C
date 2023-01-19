// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray(int size, int left, int right)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(left, right); // генератор случайных чисел
    }

    return array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите левую границу массива: ");
int left = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите правую границу массива: ");
int right = Convert.ToInt32(Console.ReadLine());

int[] massive = GetRandomArray(size,left,right);
int summ = 0;

Console.Write("Ваш массив: ");
for(int i = 0; i < massive.Length; i++)
{
    if (i % 2 != 0)
    {
        summ = summ + massive[i]; // сумма элементов, если остаток индекса не равен 0
    }
    Console.Write($"{massive[i]} "); // выводит элементы массива
}

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {summ}");
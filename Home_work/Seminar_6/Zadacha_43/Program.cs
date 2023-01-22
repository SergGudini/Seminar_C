// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] Coordinates(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine()); // ввод координат прямых
    }

    return array;
}

int size = 4;

Console.WriteLine("Введите координаты точек по порядку (k1,b1) и (k2,b2)");
double[] array = Coordinates(size);

double x = 0;
double y = 0;

x = (array[3] - array[1]) / (array[0] - array[2]);
y = (array[0] * (array[3] - array[1]) / (array[0] - array[2])) + array[1];

Console.WriteLine($"Точка пересечения: ({x};{y})");

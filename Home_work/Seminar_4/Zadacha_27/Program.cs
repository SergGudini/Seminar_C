// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int SizeOfNumber (int number) // определение размера вводимого числа
{
     int size = 0;
    while (number != 0)
    {
        number = number / 10;
        size ++; 
    }
    return size;
}

int SummNumber (int size, int number) // расчет суммы чисел
{
    int sum = 0;
    while (size != 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
        size--; 
    }
    return sum;
}

Console.Write("Введите число: "); 
int chislo = Convert.ToInt32(Console.ReadLine()); // ввод пользователем числа  с консоли

int size = SizeOfNumber(Math.Abs(chislo)); // если вводимое число отрицательное, то берем от него модуль 
                                           // и расчитываем размер введенного числа

Console.Write($"Сумма чисел: {SummNumber(size,Math.Abs(chislo))}");
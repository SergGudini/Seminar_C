// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
int number = 0;
void start(int x)
{
    Console.Write("Введите пятизначное число: "); // ввод числа
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int size = 0;
while (number != 0) //определяем размер введенного числа
{
    number = number / 10;
    size ++; 
}

Console.Write(size);
return start;
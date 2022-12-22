// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: "); // ввод числа
int[] number = new int[5];
int j = 4;
int check = 0;

for (int i = 0; i < 5; i++) {number[i] = Convert.ToInt32(Console.ReadLine());} // заполнение массива

for (int i = 0; i < 4; i++) // сравнение первой цифры (i) и последней (j) и так до середины
{
    if (number[i] == number [j]) 
    {
        check = 1; 
        j--;
    }
    else 
    {
        check = 0;
        break;   
    }
}

if (check == 1) Console.WriteLine("\r\nПолиндром"); // вывод
else Console.WriteLine("\r\nНе полиндром");

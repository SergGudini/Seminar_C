/*int number = new Random().Next(10,100); //рандом от 10 до 99
int result = number / 10;
Console.WriteLine(result);
Console.WriteLine(number);*/

//Напишите программу, которая выводит случайное 
//трехзначное число и удаляет вторую цифру этого числа.
/*int number = new Random().Next(100,1000);

Console.WriteLine(number);

int first = number / 100;
int thrid = number % 10;
int result = (first * 10) + thrid;

Console.WriteLine(result);*/


//Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.

/*int number = new Random().Next(10,100);

Console.WriteLine(number);

if (((number % 7) == 0) & ((number % 23) == 0))
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine("Не кратно");*/

//Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

int first2 = 0;
int second2 = 0;

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
if (first < 0) {first2 = first * (-1);}
else first2 = first;

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (second < 0) {second2 = second * (-1);}
else second2 = second;

if (Math.Sqrt(first2) == second2)
{
    Console.WriteLine($"Число {first} квадрат {second}");
}
else if (Math.Sqrt(second2) == first2) 
{
    Console.WriteLine($"Число {second} квадрат {first}");
}
else Console.WriteLine($"Числа {first} и {second} не квадраты друг друга");

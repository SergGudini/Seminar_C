// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = 0;
int result = number;
int i = 0;

while (number != 0) //определяем размер введенного числа
{
    number = number / 10;
    size ++; 
}

if (size >= 3) // проверяем количество введенных цифр, если 3 и больше выводим 3-ю цифру
{
    while (i < (size - 3)) // делим столько раз пока не останется 3 цифры
    {
        result = result / 10;
        i++;
    }
    
    Console.Write($"Третья цифра: {Math.Abs(result % 10)}"); // выводи 3-ю цифру
}
else Console.Write("Третьей цифры нет"); // иначе 3-ей цифры нет

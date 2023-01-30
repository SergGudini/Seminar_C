// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

/*void NaturalNumber(int N)
{
    if (N == 0) return;
    NaturalNumber(N-1);
    Console.Write(N + " ");
}

int number = 5;
NaturalNumber(number);*/

// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/*void NaturalNumber(int N, int M)
{
    if (M == N + 1) return;

    else Console.Write(M + " "); NaturalNumber(N, M + 1);
    
}

int number1 = 4;
int number2 = 8;
NaturalNumber(number2, number1);*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SummaNumber(int number)
{
    int sum = 0;
    if (number == 10) return 0;
    else
    {
        sum = number % 10 + SummaNumber(number / 10);
    }
    return sum;
}

int N = 453;
SummaNumber(N);
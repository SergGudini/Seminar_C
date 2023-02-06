// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int NaturalNumber(int M, int N)
{
    int sum = 0;
    if (N == M-1) return 0;
    sum = N + NaturalNumber(M, N - 1);
    return sum;
}

int M = 1;
int N = 15;
Console.Write(NaturalNumber(M, N));

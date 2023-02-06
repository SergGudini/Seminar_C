// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

void NaturalNumber(int N)
{
    if (N == 0) return;
    //count--;
    Console.Write(N + " ");
    NaturalNumber(N - 1);
    
}

int number = 5;
NaturalNumber(number);

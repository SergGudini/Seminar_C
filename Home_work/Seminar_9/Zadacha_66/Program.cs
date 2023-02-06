// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int NaturalNumber(int M, int N)
{
    int sum = 0;
   /* if (M == 0) Console.Write((N * (N + 1)) / 2);            // Если M равно нулю
    if (N == 0) Console.Write((M * (M + 1)) / 2);       // Если N равно нулю
    if (M == N) Console.Write(M);                       // Если M=N
    if (M < N) 
    {*/
        sum = N + NaturalNumber(M, N - 1);
        Console.Write(sum); // Если M<
   /* }
    if (M > N) 
    {
        sum = N + NaturalNumber(M, N + 1);
        Console.Write(sum); 
    }  */
}

int M = 1;
int N = 5;
NaturalNumber(M, N);

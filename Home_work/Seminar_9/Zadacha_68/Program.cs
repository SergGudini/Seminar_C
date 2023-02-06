// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AkermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0 && M > 0) return AkermanFunction(M - 1, 1);
    else if (M > 0 && N > 0) return AkermanFunction(M - 1, AkermanFunction(M, N - 1));
    else return 0;
}

int M = 2;
int N = 3;
Console.Write(AkermanFunction(M, N));

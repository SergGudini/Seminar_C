// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

int Stepen (int number1, int number2)
{
    int i = 1;
    int result = 1;
    while (i <= number2)
    {
        result = result * number1;
        i++;
    }
    return result;
}

Console.Write("Введите число: ");
int chislo_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int chislo_2 = Convert.ToInt32(Console.ReadLine());

if(chislo_2 >= 0)
{
   Console.Write(Stepen(chislo_1,chislo_2));
}
else Console.Write("Вы ввели отрицательную степень. Поэтому конец."); 



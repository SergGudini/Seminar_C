// Ввод целого числа и вывод его квадрата
//Console.Write("Enter celoe chislo: ");
//конвертиация строки в число
//int chislo = Convert.ToInt32(Console.ReadLine()); 
//вывод результата
//Console.WriteLine($"Result = {chislo * chislo}");

//Задача 1
/*
Console.Write("Введите число 1: ");
int chislo_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int chislo_2 = Convert.ToInt32(Console.ReadLine());

if ((chislo_2 * chislo_2) == chislo_1)
{
   Console.Write("Да"); 
}
else Console.Write("Нет");
*/

//Задача 2
/*Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1){
    Console.WriteLine("Понедельник");
}
else if(day == 2){
    Console.WriteLine("Вторник");
}
else if(day == 3){
    Console.WriteLine("Среда");
}
else if(day == 4){
    Console.WriteLine("Четверг");
}
else if(day == 5){
    Console.WriteLine("Пятница");
}
else if(day == 6){
    Console.WriteLine("Суббота");
}
else if(day == 7){
    Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Такого дня недели не существует");*/

//Задача 7
/*Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Последнее число: {number % 10}");*/

//Задча 5
Console.Write("Введите целое число: ");

int celoe = Convert.ToInt32(Console.ReadLine());
int i = celoe * (-1);

while(i < celoe){
    Console.WriteLine(i);
    i++;
}
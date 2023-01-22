// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

string StopSlovo = "stop";
string number = "";
int count = 0;
Console.WriteLine("Введите числа:");

while (true)
{
    number = Console.ReadLine()!;

    if(StopSlovo == number) break;
    
    if(Convert.ToInt32(number) > 0) count++; // проверка больше нуля
}

Console.WriteLine($"{count} число (числа, чисел) больше 0 ввёл пользователь");
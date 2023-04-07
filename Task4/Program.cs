//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


// РЕШЕНИЕ
// так нет в постановке задачи нет уточнения, что именно могут быть за числа, берем по максимуму
Console.Write("Enter number 1: ");
double number1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Enter number 2: ");
double number2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Enter number 3: ");
double number3 = Convert.ToDouble(Console.ReadLine()!);

double max = number1;

if (number2 > max)
    max = number2;

if (number3 > max)
    max = number3;

Console.WriteLine($"Max = {max}");
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3


// РЕШЕНИЕ
// так нет в постановке задачи нет уточнения, что именно могут быть за числа, берем по максимуму
Console.Write("Enter number 1: ");
double number1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Enter number 2: ");
double number2 = Convert.ToDouble(Console.ReadLine()!);

if (number2 > number1)
    Console.WriteLine($"Max = {number2}");
else
    Console.WriteLine($"Max = {number1}");
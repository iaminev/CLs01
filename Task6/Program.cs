//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4->да
//- 3->нет
//7->нет

//РЕШЕНИЕ
// так нет надо проверять на четность, упростим и решим, что работаем с целыми числами
Console.Write("Enter number to check: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number % 2 == 0)
    Console.WriteLine($"Number {number} is even");
else
    Console.WriteLine($"Number {number} is odd");

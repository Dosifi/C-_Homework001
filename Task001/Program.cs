// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if(number1 > number2) 
Console.WriteLine($"Большее число  {number1} Меньшее число  {number2}");
else
Console.WriteLine($"Большее число  {number2} Меньшее число  {number1}");
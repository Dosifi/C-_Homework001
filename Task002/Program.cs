// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (max < number2)
max = number2;
if (max < number3)
max = number3;

Console.WriteLine($"Наибольшее число {max}");

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine()!);

int ostatok = number % 2;

if (ostatok == 0)
Console.WriteLine("Число чётное");
else
Console.WriteLine("Число нечётное");
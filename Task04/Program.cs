﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Напишите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int numberMax = number1;

if (number2 > numberMax) numberMax = number2;

if (number3 > numberMax) numberMax = number3;

Console.WriteLine($"Максимальное число из введенных равно {numberMax}");
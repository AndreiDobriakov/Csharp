﻿// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] CreateArray(int size, int min, int max)
{
Console.Write("Введите количество элементов в массиве: ");
    
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = ;
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }

    return new int[] { sumPositive, sumNegative };
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }

    return sum;
}

int[] array = CreateArrarRndint(12, -9, 9);
PrintArray(array);
// Console.Write(" ->[");
// PrintArray(array);
// Console.WriteLine("]");



int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумма положительных элеметов -> {sumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элеметов -> {sumPositiveNegativeElem[1]}");

int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine($"Сумма положительных элеметов -> {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных элеметов -> {sumNegativeElem}");
﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int UserNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateCustomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new();
    for (int i =0; i < size; i++){
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArrayInt(int[] arr) //Метод, который выводит массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[^1]}]");
}

int[] DuplicateArray(int[] array)
{
    int size = array.Length;
    int[] duplicateArray = new int[size];
    for (int i =0; i < size; i++)
    {
       duplicateArray[i] = array[i];
    }
    return duplicateArray;
}

Console.WriteLine("Create Array");
int userSize = UserNumber("Enter the size of array");
int userMin = UserNumber("Enter the min digit for range");
int userMax = UserNumber("Enter the max digit for range");
int[] userArray = CreateCustomArray(userSize, userMin, userMax);
PrintArrayInt(userArray);
int[] newArray = DuplicateArray(userArray);
// newArray[1] = 2000;
PrintArrayInt(newArray);

// Console.WriteLine("Create Array");
// int userSize = UserNumber("Enter the size of array");
// int userMin = UserNumber("Enter the min digit for range");
// int userMax = UserNumber("Enter the max digit for range");
// int[] userArray = CreateCustomArray(userSize, userMin, userMax);
// PrintArrayInt(userArray);
// Console.WriteLine("-> userArray");
// int[] newArray = DuplicateArray(userArray);
// int[] array2 = userArray;
// userArray[1] = 1000;
// PrintArrayInt(newArray);
// Console.WriteLine("-> newArray");
// PrintArrayInt(array2);
// Console.WriteLine("-> array2");
// PrintArrayInt(userArray);
// Console.WriteLine("-> userArray");
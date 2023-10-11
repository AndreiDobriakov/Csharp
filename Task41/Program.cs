// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int GetUserInput(string message)
// {
//     Console.Write($"{message}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[] CreateArray()
// {
//     Console.Write("Введите количество элементов в массиве: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] Array = new int[size];
//     void massiv(int size)
//     {
//         for (int i = 0; i < size; i++)
//         {
//             Console.Write("Введите элемент массива");
//             Array[i] = Convert.ToInt32(Console.ReadLine());
//         }
//     }

// }



int CountPositiveElem(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine($"В данном массиве {CountPositiveElem(array)} положительных элементов");
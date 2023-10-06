// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] CreateArrayRandom(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int SumOddPos(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i = i+2) // i = 1, если позиции считаются с 0 ? 
    {
        sum = sum + arr[i];
        // Console.Write($"{arr[i]}, "); // Выводит список считаемых цифр для проверки пользователем.
    }
    return sum;
    
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

int[] array = CreateArrayRandom(10, 0, 10);
PrintArray(array);
int result = SumOddPos(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {result}");
// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int fac = 1;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            fac *= i;
        }
    }

    return fac;
}

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Произведение числел от 1 до {number} = {factorial}");
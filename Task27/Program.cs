// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumNumber(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}


int number = GetUserInput("Enter a number");
int sumNumber = SumNumber(number);

Console.WriteLine($"Сумма цыфр числа {number} равно {sumNumber}");
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int ShowSecondDigit(int num)
{
    int thirdDigit = num % 10;
    int secondDigit = (num % 100 - thirdDigit) / 10;
    return secondDigit;
}
Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 & number <1000)
{
    int result = ShowSecondDigit(number);
    Console.WriteLine($"Вторая цифра данного числа {result}");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
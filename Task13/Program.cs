// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int ShowThirdDigit(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int result = ShowThirdDigit(number);
    Console.WriteLine($"Третья цифра данного числа равна {result}");
}
else
{
    Console.WriteLine("У данного числа третьей цыфры нет");
}
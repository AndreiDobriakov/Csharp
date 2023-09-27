// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool Weekend(int weekend)
{
    if (weekend == 6 || weekend == 7)
    {
        return true;
    }
    return false;
}
bool RealDay(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    Console.WriteLine("Вы ввели не корректное число");
    return false;
}
Console.WriteLine("Введите число от 1 до 7");
int weekend = Convert.ToInt32(Console.ReadLine());

if (RealDay(weekend))
{
    if (Weekend(weekend))
    {
        Console.WriteLine("Данный день недели выходной!");
    }
    else
    {
        Console.WriteLine("Данный день недели не является выходным");
    }
}

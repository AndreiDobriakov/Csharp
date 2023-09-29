// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False



int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsPalindrome(int number)
{
    if (number > 9999 && number < 100000)
    {
        if ((number / 10000 == number % 10) & (number / 1000 % 10 == number % 100 / 10))
        {
            return true;
        }
        return false;
    }
    Console.WriteLine("Вы ввели не пятизначное число");
    return false;
}

Console.WriteLine("Введите пятизначное число");
int polindrom = Convert.ToInt32(Console.ReadLine());


if (IsPalindrome(polindrom))
{
    Console.WriteLine("Данное число является полиндромом");
}


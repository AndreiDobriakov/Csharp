// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

// int firstDigit = number / 100; w
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
int result = DeleteSecondDigit(number);
Console.WriteLine(result);
// Напишите программу, которая 
// 1. на вход принимает два числа
// 2. считает какое число большее, а какое меньшее.
// 3. выдает результат
// Пример
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Данное число {number1}, большее.");
    Console.WriteLine($"Данное число {number2}, меньшее.");
}
else if (number2 > number1)
{
    Console.WriteLine($"Данное число {number2}, большее.");
    Console.WriteLine($"Данное число {number1}, меньшее.");
}
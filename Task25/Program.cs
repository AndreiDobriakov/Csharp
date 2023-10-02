// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int DegreeNumbers(int num1, int num2)
{
    int count = 1;
    int degreeNumbers = num1;
    while (count <= num2)
    {
        degreeNumbers = degreeNumbers * num1;
        count++;
    }
    return degreeNumbers;
}
Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа:");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = DegreeNumbers(number1, number2);

Console.WriteLine($"Число {number1} в степени {number2} равно {result}");
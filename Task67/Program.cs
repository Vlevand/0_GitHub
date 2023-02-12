// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int Factorial(int n)
// {
//     if (n == 1) return 1;

//     return n * Factorial(n - 1);
// }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
int sumResult = SumDigitNumber(number);
Console.Write($"Сумма цифр числа {number} = {sumResult}");


int SumDigitNumber(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumDigitNumber(n / 10);
}

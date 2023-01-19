/* Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int SecondDigit(int number)
{
    if (number < 0) number = -number;
    int result = number / 10 % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if ((digit > 99 && digit < 1000) || (digit > -1000 && digit < -99))
Console.WriteLine($"Второе число в числе {digit}: {SecondDigit(digit)}");
else Console.WriteLine("Ошибка! Введено не трехзначное число.");
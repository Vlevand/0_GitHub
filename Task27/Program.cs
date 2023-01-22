// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int a)
{
    if (a < 0) a = -1 * a;
    int result = 0;
    do
    {
        result = result + a % 10;
        a = a / 10;
    } while (a > 0);
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigits(number);
Console.Write($"Сумма цифр числа {number} = {sum}");

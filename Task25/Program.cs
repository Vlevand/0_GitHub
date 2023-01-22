/* Напишите цикл, который
1) принимает на вход два числа (A и B) и
2) возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int PowerPlus(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}

double PowerMinus(int x, int y)
{
    y = -1 * y;
    double result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    result = 1 / result;
    return result;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    int powerPlus = PowerPlus(a, b);
    Console.Write($"{a} в степени {b} = {powerPlus}");
}
else
{
    if (b < 0)
    {
        double powerMinus = PowerMinus(a, b);
        Console.Write($"{a} в степени {b} = {powerMinus}");
    }
    else Console.Write($"{a} в степени {b} = 1");
}

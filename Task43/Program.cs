/* Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double k1, k2, b1, b2, x, y;
Console.WriteLine("Даны уравнения y = k1 * x + b1 и y = k2 * x + b2 .");
Console.WriteLine("Введите коэффициенты k1, b1, k2, b2 :");

// ввод через строку
Console.WriteLine("(числа вводите через пробел, по окончанию нажмите Enter)");
string str = Console.ReadLine();
string[] arrayStr = str.Split();
k1 = Convert.ToDouble(arrayStr[0]);
b1 = Convert.ToDouble(arrayStr[1]);
k2 = Convert.ToDouble(arrayStr[2]);
b2 = Convert.ToDouble(arrayStr[3]);

// простой пользовательский ввод
// Console.Write("k1 :");
// k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("b1 :");
// b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("k2 :");
// k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("b2 :");
// b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"y = {k1} * x + {b1} и y = {k2} * x + {b2}");

if (k1 != k2 && b1 != b2)
{
    x = Math.Round(XInFuction(k1, b1, k2, b2), 2);
    y = Math.Round(YInFuction(k1, b1, x), 2);
    Console.WriteLine($"Две прямые пересекутся в точке ({x}; {y})");
}
else if (k1 != k2 && b1 == b2) Console.WriteLine($"Две прямые пересекутся в точке (0; {b1})");
     else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу, точки пересечения нет.");


// нахождение x
double XInFuction(double kx1, double bx1, double kx2, double bx2)
{
    return (bx2 - bx1) / (kx1 - kx2);
}

// вычисление у
double YInFuction(double kx1, double bx1, double xx)
{
    return kx1 * xx + bx1;
}
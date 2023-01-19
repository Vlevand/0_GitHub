/* Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

bool Square(int onenumb, int twonumb)
{
    return onenumb==twonumb*twonumb || twonumb == onenumb*onenumb;
}

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Square(firstDigit, secondDigit) ? "Одно число является квадратом другого" : "Одно число не является квадратом другого");




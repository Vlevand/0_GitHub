/* Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 1)
{
    Console.WriteLine("N -> Sqrt(N)");
    for (int i = 1; i <= n; i++)
        Console.WriteLine(TableSqrt(i));
}
else Console.Write("Ошибка!!! Введено не натуральное число.");

string TableSqrt(int x)
{
    return Convert.ToString(x) + "   " + Convert.ToString(x * x);
}
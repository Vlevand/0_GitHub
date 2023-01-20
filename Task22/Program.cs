/* Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N. */

/* Вариант решения 1

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine("N -> Sqrt(N)");
    for (int i = 1; i <= n; i++)
        Console.WriteLine(TableSqrt(i));
}
else Console.Write("Ошибка!!! Введено не натуральное число.");

string TableSqrt(int x)
{
    return Convert.ToString(x) + "   " + Convert.ToString(x * x);
} */

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) TabelSquare(n);
else Console.Write("Ошибка!!! Введено не натуральное число.");

void TabelSquare(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 4} {count*count, 4}");
        count++;
    }
}
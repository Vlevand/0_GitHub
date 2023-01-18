/* Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.Write($"Числа {a} и {b} равны.");
}
else
{

    if (a > b)
    {
        Console.Write($"Число {a} больше числа {b}.");
    }
    else
    {
        Console.Write($"Число {b} больше числа {a}.");
    }
}
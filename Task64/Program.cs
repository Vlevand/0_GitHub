// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (NaturalNumber(number)) NumberFromNTo1(number);
else Console.WriteLine("Ошибка!!! Введено число меньше 1.");


void NumberFromNTo1 (int n)
{
    if (n == 1) Console.Write($"{n}");
    else
    {
    Console.Write($"{n}, ");
    NumberFromNTo1(n-1);
    }
}

bool NaturalNumber(int x)
{
    return x > 0;
}
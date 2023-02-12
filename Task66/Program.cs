/* Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
if (NaturalNumber(m))
{
    Console.Write("Введите натуральное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (NaturalNumber(n))
    {
        if (m != n)
        {
            int[] arr = MaxFromTwoNumber(m, n);
            int sumNumbers = SumFromMToN(arr[0], arr[1]);
            Console.WriteLine($"Cумму натуральных элементов в промежутке от {arr[1]} до {arr[0]} = {sumNumbers}");
        }
        else Console.WriteLine($"Числа M и N = {m}");
    }
    else Console.WriteLine("Ошибка!!! Введено число меньше 1.");
}
else Console.WriteLine("Ошибка!!! Введено число меньше 1.");


int SumFromMToN(int max, int min)
{
    if (max == min) return min;
    return max + SumFromMToN (max - 1, min);
}

int[] MaxFromTwoNumber(int a, int b)
{
    int[] array = new int[2];
    if (a > b)
    {
        array[0] = a;
        array[1] = b;
    }
    else
    {
        array[0] = b;
        array[1] = a;
    }
    return array;
}

bool NaturalNumber(int x)
{
    return x > 0;
}
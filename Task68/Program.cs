// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
if (NaturalNumber(m))
{
    Console.Write("Введите натуральное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (NaturalNumber(n))
    {
        int akker = Akkerman(m, n);
        Console.WriteLine($"A({m}, {n}) = {akker}");
    }
    else Console.WriteLine("Ошибка!!! Введено отрицательное число.");
}
else Console.WriteLine("Ошибка!!! Введено отрицательное число.");

int Akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else if (y == 0) return Akkerman(x - 1, 1);
    else return Akkerman(x - 1, Akkerman(x, y - 1));
}

bool NaturalNumber(int x)
{
    return x > -1;
}
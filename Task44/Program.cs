// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число (от 0): ");
int n = Convert.ToInt32(Console.ReadLine());
if (IsNumberPositiv(n))
{
    int[] f = Fibonachchi(n);
    Console.Write($"Числа Фибоначчи ({n}) -> ");
    PrintArray(f);
}
else Console.WriteLine("Ошибка!!!Введены неверные данные.");


// числа Фибоначи через цикл
int[] Fibonachchi(int number)
{
    int[] numberFibonachchi = new int[number];
    numberFibonachchi[0] = 0;
    numberFibonachchi[1] = 1;
    for (int i = 2; i < number; i++)
    {
        numberFibonachchi[i] = numberFibonachchi[i-1] + numberFibonachchi[i-2];
    }
    return numberFibonachchi;
}

// проверка на положительность числа, включая 0
bool IsNumberPositiv(int x)
{
    return x >= 0;
}

//вывод массива для чисел Фибоначчи
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
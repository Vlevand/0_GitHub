// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число : ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA / numberB == numberB)
{
    Console.WriteLine($"Первое число {numberA} квадрат второго числа {numberB}");
}
else
{
    Console.WriteLine($"Первое число {numberA} не является квадратом второго числа {numberB}");
}
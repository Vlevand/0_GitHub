// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
if (number < 0) number = number * -1;
int numberOfDigits = NumberOfDigits(number);
Console.WriteLine($"В числе {number} {numberOfDigits} цифры");

int NumberOfDigits(int x)
{
    int result = 1; // =0 то ноль не учитывается
        while (x >= 10) // x != 10 чтоб считал и отрицательные
        {
            x = x / 10;
            result++;
        }
    return result;
}
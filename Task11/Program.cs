/* Напишите программу, которая
1) выводит случайное трёхзначное число и
2) удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98 */

int NewDigit(int digit)
{
    int result = 10 * (digit / 100) + digit % 10;
    return result;
}

int numb = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {numb}");

int newNumber = NewDigit(numb);
Console.WriteLine($"Двухзначное число из первой и последней цифры => {newNumber}");
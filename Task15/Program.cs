/* Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

bool Weekend(int number)
{
    return number == 6 || number == 7;
}

Console.Write("Введите число от 1 до 7: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit > 7 || digit < 1)
Console.Write("Ошибка! Введено число не от 1 до 7.");
else Console.Write(Weekend(digit) ? "Выходной" : "Не выхоной");
/* Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100000 && n > 9999 || n < -9999 && n > -100000)
    Console.Write(PalindromeNumber(n) ? "Данное число является палиндромом." : "Данное число не является палиндромом.");
else
    Console.Write("Ошибка!!! Введено не пятизначное число.");

bool PalindromeNumber(int x)
{
    int z = x;
    string y = "";
    while (x != 0)
    {
        y = y + Convert.ToString(x % 10);
        x = x / 10;
    }
    if (z == Convert.ToInt32(y)) return true; else return false;
}
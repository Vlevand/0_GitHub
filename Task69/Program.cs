/* Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
int result = APowerB(a, b);
Console.Write($"Число А {a} в степени B {b} = {result}");
}
else Console.Write("Ошибка!!! Введены неверные данные");


int APowerB(int number, int power)
{
    if (power == 0) return 1;
    else return number * APowerB(number, power-1);
}


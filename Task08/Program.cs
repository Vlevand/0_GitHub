/* Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();
Console.Write("Введите целое положительное число от 2: ");
int x = Convert.ToInt32(Console.ReadLine()), count = 2;
if (x < 2) Console.Write("Ошибка! Введены некорректные данные.");
else
{
    while (count <= x)
    {
    Console.Write(count+" ");
    count +=2;
    }
}
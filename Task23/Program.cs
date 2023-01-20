/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0) TabelSquare(n);
else Console.Write("Ошибка!!! Введено не натуральное число.");

void TabelSquare(int number)
{
    Console.WriteLine("N -> N в кубе");
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 6} {count*count*count, 6}");
        count++;
    }
}

/* Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int a = 46;
int ba = BinaryNumber(a);
Console.WriteLine($"{a} -> {ba}");

int BinaryNumber(int x)
{
    int x2 = 0, x3 = 1;
    while (x != 0)
    {
        x2 = x2 + (x % 2) * x3;
        x3 = x3 * 10;
        x = x / 2;
    }
    return x2;
}
/*  Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"  */

Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = x;
if (x>0)
{
    count = -x;
   while (count <= x)
   {
    Console.Write(count);
    Console.Write(" ");
    count++;
   } 
}
else
{
    while (count <= -x)
    {
       Console.Write(count);
       Console.Write(" ");
       count++; 
    }
}
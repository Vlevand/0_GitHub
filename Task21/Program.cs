/* Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки А");
Console.Write("x1: ");
int ax1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int ay1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int az1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("x2: ");
int bx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int by2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int bz2 = Convert.ToInt32(Console.ReadLine());

string answer = Convert.ToString(DistanceBetweenPoints(ax1, ay1, az1, bx2,  by2, bz2));

Console.Write($"Расстояние между точками А({ax1},{ay1},{az1}) и В({bx2},{by2},{bz2}) равно " + answer);

double DistanceBetweenPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)
    + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2)), 2, MidpointRounding.ToZero);
    return distance;
}
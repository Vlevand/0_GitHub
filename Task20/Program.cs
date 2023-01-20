/* Напишите программу, которая
1) принимает на вход координаты двух точек и
2) находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21

Math.Pow(2, 2);
double d = Math.Sqrt(355);

double num = 5.099873456;
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
Console.WriteLine(numRound); */

Console.WriteLine("Введите координаты точки А");
Console.Write("x1: ");
int ax1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int ay1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.Write("x2: ");
int bx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int by2 = Convert.ToInt32(Console.ReadLine());

string answer = Convert.ToString(DistanceBetweenPoints(ax1, ay1, bx2,  by2));

Console.Write($"Расстояние между точками А({ax1},{ay1}) и В({bx2},{by2}) равно " + answer);

double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)
    + Math.Pow(y2 - y1, 2)), 2, MidpointRounding.ToZero);
    return distance;
}
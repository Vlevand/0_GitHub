// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.Write("Введите первое положительное число: ");
int ab = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе положительное число: ");
int bc = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье положительное число: ");
int ac = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TriangleInequality(ab, bc, ac) ? "Треугольник с такими сторонами существует"
                    : "Треугольник с такими сторонами не существует");

bool TriangleInequality(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
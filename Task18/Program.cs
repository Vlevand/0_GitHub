/* Напишите программу, которая
1. по заданному номеру четверти,
2. показывает диапазон возможных координат точек в этой четверти (x и y). */

string  Coordinates(int qc)
{
if (qc == 1) return "Диапазон координат: x > 0, y > 0";
if (qc == 2) return "Диапазон координат: x < 0, y > 0";
if (qc == 3) return "Диапазон координат: x < 0, y < 0";
if (qc == 4) return "Диапазон координат: x > 0, y < 0";
return "Введен некорректный номер четверти!";
}

Console.Write("Введите номер четверти: ");
int qarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Coordinates(qarter));





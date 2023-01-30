/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого элемента в массиве нет */


Console.WriteLine("Введите индексы позиции элемента в двумерном массиве,");
Console.WriteLine("(индексы, целые числа, начинаются с 1 строки/столбца)");
Console.Write("номер строки -> ");
int r = Convert.ToInt32(Console.ReadLine());
if (IsNumberPositiv(r))
{
    Console.Write("номер столбца -> ");
    int c = Convert.ToInt32(Console.ReadLine());
    if (IsNumberPositiv(c))
    {
        int[,] array2D = CreateMatrixRndInt(15, 11, -10, 10);
        PrintMatrix(array2D);
        if (IsElemInMatrix(array2D, r, c))
        {
            int elem = ElemMatrixWithIndex(array2D, r, c);
            Console.WriteLine($"Элемент с индексами ({r},{c}) = {elem}");
        }
        else Console.WriteLine($"В данном массиве элемент с индексами ({r},{c}) отсутствует.");

    }
    else Console.WriteLine("Ошибка!!!Введены неверные данные.");
}
else Console.WriteLine("Ошибка!!!Введены неверные данные.");


// возвращение значения элемента по индексу
int ElemMatrixWithIndex(int[,] matrix, int rows, int columns)
{
    return matrix[rows - 1, columns - 1];
}

// проверка наличия элементов в заданом массиве
bool IsElemInMatrix(int[,] matrix, int rows, int columns)
{
    return rows - 1 <= matrix.GetLength(0) && columns - 1 <= matrix.GetLength(1);
}

// проверка на положительность числа, включая 0
bool IsNumberPositiv(int x)
{
    return x > 0;
}

// создание двумерного массива и заполнение его случайнымы целыми числами из интервала [min, max]
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}
/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива */

Console.Clear();
int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
SwappingFirstAndPastRows(array2D);
Console.WriteLine("Массив с поменеными местами первой и последней строкой:");
PrintMatrix(array2D);


// масив с поменяными первой и последней строкой
void SwappingFirstAndPastRows(int[,] matrix)
{
    int x = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        x = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = x;
    }
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] array2D = CreateMatrixRndInt(4, 4, -9, 15);
PrintMatrix(array2D);
int sumElemMainDiagonal = SumElemMainDiagonal(array2D);
Console.WriteLine($"Сумма элементов главной диагонали = {sumElemMainDiagonal}");


// сумма элементов главной диагонали
int SumElemMainDiagonal(int[,] matrix)
{
    int result = 0, count = matrix.GetLength(0);
    if (count > matrix.GetLength(1)) count = matrix.GetLength(1);
    for (int i = 0; i < count; i++)
    {
        result += matrix[i, i];
    }
    return result;
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
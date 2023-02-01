// Задайте двумерный массив.Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


Console.Clear();
int[,] array2D = CreateMatrixRndInt(7, 8, -10, 10);
if (IsMatrixSquare(array2D))
{
    Console.WriteLine("Исходный массив:");
    PrintMatrix(array2D);
    ReplacementRowsWithColumns(array2D);
    Console.WriteLine("Массив с поменеными местами строками и столбцами:");
    PrintMatrix(array2D);
}
else Console.WriteLine("В заданом массиве поменять строки и столбцы невозможно!");


// замена строк на столбцы
void ReplacementRowsWithColumns(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0)-1; i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

// проверка массива на квадратность
bool IsMatrixSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
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
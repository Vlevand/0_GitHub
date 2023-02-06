/* Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */


int[,] matrix1 = CreateMatrixRndInt(5, 4, -15, 15);
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
int[,] matrix2 = CreateMatrixRndInt(4, 7, -15, 15);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
if (IsMatrixsCompatibili(matrix1, matrix2))
{
    int[,] matrix3 = MatrixMultiplication(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(matrix3);
}
else Console.WriteLine("Матрицы не совместимы.");


// умножение матриц
int[,] MatrixMultiplication(int[,] mtx1, int[,] mtx2)
{
    int[,] resultMtx = new int[mtx1.GetLength(0), mtx2.GetLength(1)];

    for (int i = 0; i < resultMtx.GetLength(0); i++)
    {
        for (int j = 0; j < resultMtx.GetLength(1); j++)
        {
            for (int g = 0; g < mtx1.GetLength(1); g++)
            {
                resultMtx[i, j] = resultMtx[i, j] + mtx1[i, g] * mtx2[g, j];
            }
        }
    }
return resultMtx;
}

// проверка матриц на совместимость
bool IsMatrixsCompatibili(int[,] mtx1, int[,] mtx2)
{
    return mtx1.GetLength(1) == mtx2.GetLength(0);
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

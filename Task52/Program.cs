// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


int[,] array2D = CreateMatrixRndInt(3, 10, -10, 10);
PrintMatrix(array2D);
double[] array = ArithmeticMeanColumns(array2D);
Console.WriteLine("Среднее арифметическое по столбцам:");
PrintArray(array);



// среднее арифмитическое столбцов
double[] ArithmeticMeanColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result[j] = result[j] + (double)matrix[i, j];
        }
        result[j] = Math.Round(result[j] / (double)matrix.GetLength(0), 1);
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

// вывод одномерного массива
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],6}");
    }
    Console.WriteLine();
}
// Задайтедвумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.


int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
int[] array = IndexMinVal(array2D);
Console.WriteLine($"Координаты минимального элемента массива -> ({array[0]},{array[1]})");
int[,] newArray2D = MatrixWithoutRowColumnWithMinElem(array2D, array[0], array[1]);
Console.WriteLine("Массив без строки и столбца с минимальным элементом:");
PrintMatrix(newArray2D);


// поиск индексов минимального элемента
int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] indexMin = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    return indexMin;
}


// удаление строки и стобца с минимальным элементом
int[,] MatrixWithoutRowColumnWithMinElem(int[,] matrix, int imin, int jmin)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m = 0, n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == imin) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == jmin) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
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
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],5}");
    }
    Console.WriteLine();
}
/* Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


int[,] array2D = CreateMatrixRndInt(7, 5, -5, 5);
Console.WriteLine("Исходный массив:");
PrintMatrix(array2D);
Console.WriteLine("Отсортированный массив:");
SortElemRowsInMatrix(array2D);
PrintMatrix(array2D);


// сортировка по убыванию элементов массива в строках
void SortElemRowsInMatrix(int[,] matrix)
{
    int jMaxElem;
    for (int p = 0; p < matrix.GetLength(0); p++)
    {
        for (int g = 0; g < matrix.GetLength(1) - 1; g++)
        {
            jMaxElem = IndexMaxElemRow(matrix, p, g);
            MovingMaxElemOnFirstPlace(matrix, p, g, jMaxElem);
        }
    }
}

// максимальный элемент строки
int IndexMaxElemRow(int[,] matrix, int rowIndex, int columnIndex)
{
    int result = columnIndex;
    int max = matrix[rowIndex, columnIndex];
    for (int j = columnIndex; j < matrix.GetLength(1); j++)
    {
        if (matrix[rowIndex, j] > max)
        {
            max = matrix[rowIndex, j];
            result = j;
        }
    }
    return result;
}

// перемещение максимального элемента на первое место
void MovingMaxElemOnFirstPlace(int[,] matrix, int rowIndex, int columnIndexCurrentPosition, int columnIndexMaxElem)
{
    int temp = 0;
    temp = matrix[rowIndex, columnIndexCurrentPosition];
    matrix[rowIndex, columnIndexCurrentPosition] = matrix[rowIndex, columnIndexMaxElem];
    matrix[rowIndex, columnIndexMaxElem] = temp;
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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}
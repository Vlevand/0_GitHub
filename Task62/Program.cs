/* *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] array2D = CreateMatrixWithElemBySpiral(4);
PrintMatrix(array2D);


// создание квадратного массива и заполнение его по спирали
int[,] CreateMatrixWithElemBySpiral(int size)
{
    int[,] matrix = new int[size, size];
    int number = 1;
    int k = 0;
    while (k <= size / 2)
    {
        for (int j = k; j < size - k; j++)
        {
            matrix[k, j] = number;
            number++;
        }
        for (int i = 1 + k; i < size - k; i++)
        {
            matrix[i, size - 1 - k] = number;
            number++;
        }
        for (int j = size - 2 - k; j >= k; j--)
        {
            matrix[size - 1 - k, j] = number;
            number++;
        }
        for (int i = size - 2 - k; i > k; i--)
        {
            matrix[i, k] = number;
            number++;
        }
        k++;
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

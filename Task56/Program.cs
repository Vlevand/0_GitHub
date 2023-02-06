// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array2D = CreateMatrixRndInt(7, 3, -3, 9);
if (IsRectangle(array2D))
{
    PrintMatrix(array2D);
    int[] arraySumRows = SumElemRows(array2D);
    int iWithMinSum = NumberRowWithMaxSumElem(arraySumRows);
    Console.WriteLine($"Номер строки массива с минимальной суммой элементов: {iWithMinSum}");
}
else Console.WriteLine("Ошибка!!! Квадратный массив.");


// нахожение сумм элементов строк в двумерном массиве
int[] SumElemRows(int[,] matrix)
{
    int sum = 0;
    int[] allSumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        allSumRows[i] = sum;
        sum = 0;
    }
    return allSumRows;
}

// нахождение строки с минимальной суммой
int NumberRowWithMaxSumElem(int[] array)
{
    int min = array[0], iMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}

// проверка на прямоугольность
bool IsRectangle(int[,] matrix)
{
    return matrix.GetLength(0) != matrix.GetLength(1);
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
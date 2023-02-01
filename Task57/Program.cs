/*  Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */

Console.Clear();
int[,] array2D = CreateMatrixRndInt(2, 3, 0, 5);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = MatrixToArray(array2D);
PrintArray(array);
Console.WriteLine();

Array.Sort(array);
PrintArray(array);
Console.WriteLine();

int[,] result = FrequencyDictionaryForArray(array);
PrintFrequencyDictionary(result);


//вывод частотного словаря
void PrintFrequencyDictionary(int[,] matrix)
{
    Console.WriteLine("Частотный словарь:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            if (matrix[i,1] != 1) Console.WriteLine($"{matrix[i, 0]} встречается {matrix[i,1]} раза");
            else Console.WriteLine($"{matrix[i, 0]} встречается {matrix[i,1]} раз");
    }
}

// частотный словарь для одномерного массива
int[,] FrequencyDictionaryForArray(int[] arr)
{
    int size = 1;// количество строк в частотном словаре
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] != arr[i + 1]) size++;
    }

    int[,] matrix = new int[size, 2];// количество строк в частотном словаре
    int a = 1; 
    matrix[0, 0] = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] != arr[i + 1])
        {
            matrix[a, 0] = arr[i + 1];
            a++;
        }
    }

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (matrix[i, 0] == arr[j]) count++;
        }
        matrix[i, 1] = count;
        count = 0;
    }
    return matrix;
}

// преобразование двумерного массива в одномерный
int[] MatrixToArray(int[,] matrix)
{
    int k = 0;
    int size = matrix.GetLength(0) * matrix.GetLength(1);
    int[] arr = new int[size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
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

// вывод одномерного массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],5}");
    }
    Console.WriteLine();
}
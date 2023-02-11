// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int ix = 4;
int jy = 2;
int gz = 3;
if (ElemMatrixBefore90(ix, jy, gz))
{
    int[,,] array3D = CreateMatrix3D(ix, jy, gz);
    PrintMatrix3D(array3D);
}
else Console.WriteLine("В массиве более 180 элементов! Невозможно заполнить неповторяющимися двузначными числами.");


// проверка на максимум элементов в массиве
bool ElemMatrixBefore90(int x, int y, int z)
{
    return x * y * z < 181;
}

// 1 вариант - создание двумерного массива и заполнение его неповторяющемися двузначными цифрами
int[,,] CreateMatrix3D(int rows, int columns, int gorizontColomns)
{
    int number = -99;
    int[,,] matrix3D = new int[rows, columns, gorizontColomns];
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int g = 0; g < matrix3D.GetLength(2); g++)
            {
                matrix3D[i, j, g] = number;
                number++;
            }
        }
    }
    return matrix3D;
}

/* 2 вариант создание двумерного массива и заполнение его неповторяющемися двузначными цифрами через список
int[,,] CreateMatrix3D(int rows, int columns, int gorizontColomns)
{
    int number = -99;
    List<int> rndNumber = new List<int>();
    for (int k = 0; k < 180; k++)
    {
        rndNumber.Insert(k, number);
        number++;
        if (number > -10 && number < 10) number = 10;
    }
    Random rnd = new Random();
    int indexElem = 0;
    int max = rndNumber.Count;
    int[,,] matrix3D = new int[rows, columns, gorizontColomns];
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int g = 0; g < matrix3D.GetLength(2); g++)
            {
                indexElem = rnd.Next(0, max);
                matrix3D[i, j, g] = rndNumber[indexElem];
                rndNumber.RemoveAt(indexElem);
                max = max - 1;
            }
        }
    }
    return matrix3D;
} */

// вывод двумерного массива
void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int g = 0; g < matrix3D.GetLength(2); g++)
            {
                Console.Write($"{matrix3D[i, j, g],6}");
                Console.Write($"({i},{j},{g})");
            }
        }
        Console.WriteLine();
    }
}

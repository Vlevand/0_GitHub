/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] array = CreateArrayRndInt(15, 1, 15);
PrintArray(array);
double maxElem = MaxElemArray(array);
Console.WriteLine($"Максимальный элемент массива = {maxElem}");
double minElem = MinElemArray(array);
Console.WriteLine($"Минимальный элемент массива = {minElem}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(maxElem - minElem, 1)}");

//поиск максимума
double MaxElemArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

//поиск минимума
double MinElemArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

//создание и заполнение массива
double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * ( max - min ) + min, 1);
    }
    return arr;
}

//вывод массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " , ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
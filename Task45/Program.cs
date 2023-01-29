/* Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */

int[] array = new int[8];
FillArrayRndInt(array, -10, 10);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Скопированный массив:");
int[] copyArray = CopyArrayByElem(array);
PrintArray(copyArray);

// поэлементное копирование массива
int[] CopyArrayByElem(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr; 
}

// заполнение массива случайными целыми числами в интевале от min до max
int[] FillArrayRndInt(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

// вывод массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

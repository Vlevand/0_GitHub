// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array1 = { 1, 2, 3, 4, 5 }, array2 = { 6, 7, 3, 6 };

PrintArray(array1);
int[] arrayResult1 = ProductOfElemArray(array1);
Console.Write("-> ");
PrintArray(arrayResult1);

Console.WriteLine();

PrintArray(array2);
int[] arrayResult2 = ProductOfElemArray(array2);
Console.Write("-> ");
PrintArray(arrayResult2);


int[] ProductOfElemArray(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2; else size = arr.Length / 2 + 1;
    int[] resultArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i) resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else resultArr[i] = arr[i];
    }
    return resultArr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("] ");
}


/* кривой метод 1

int[] ProductOfElemArray(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2; else size = arr.Length / 2 + 1;
    int[] resultArr = new int[size];

    if (arr.Length % 2 == 0) 
    {
        for (int i = 0; i < resultArr.Length; i++)
        {
            resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i < resultArr.Length - 1; i++)
        {
            resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        resultArr[resultArr.Length - 1] = arr[resultArr.Length - 1];
    }
    return resultArr;
}

костыльный метод 1

int[] ProductOfElemArray(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2; else size = arr.Length / 2 + 1;
    int[] resultArr = new int[size];
    for (int i = 0; i < size-1; i++)
    {
        resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0) resultArr[resultArr.Length - 1] = arr[resultArr.Length - 1];
    return resultArr;
} */

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int size = 8, a = 1, b = 34;
int[] arr = СompletionArr(size, a, b);
PrintArr(arr);

int[] СompletionArr(int s, int x1, int x2)
{
    int[] array = new int[s];
    Random rnd = new Random();
    for (int i = 0; i < s; i++)
    {
        array[i] = new Random().Next(x1, x2);
    }
    return array;
}

void PrintArr(int[] array1)
{
    Console.Write("[ ");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]}");
        if (i != array1.Length-1) Console.Write(", ");
    }
    Console.Write(" ]");
}
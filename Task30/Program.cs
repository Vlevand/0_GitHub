// Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void СompletionArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Random rnd = new Random();
        arr[i] = new Random().Next(0, 2); //arr[i] = rnd.Next(0, 2);
    }
}

void PrintArr(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

int[] array = new int[8];
СompletionArr(array);
PrintArr(array);
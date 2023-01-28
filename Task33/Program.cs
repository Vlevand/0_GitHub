// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool СontainingNumber(int[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n) return true;
    }
    return false;
}


int[] array = { 6, 7, 19, 345, 3 };
PrintArray(array);
Console.Write("Введите число для поиска в массиве: ");
int x = Convert.ToInt32(Console.ReadLine());
if (СontainingNumber(array, x))
    Console.WriteLine($"Число {x} содержится в массиве.");
else Console.WriteLine($"Число {x} отсутствует в массиве.");

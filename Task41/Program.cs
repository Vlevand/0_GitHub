// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Какое количество чисел хотите ввести? Введите число: ");
int quantity = Convert.ToInt32(Console.ReadLine());
if (IsNumberPositiv(quantity))
{
    int[] numbersByUser = ArrayNumberByUser(quantity);
    PrintArray(numbersByUser);
    int n = СountNaturalNumbersInArray(numbersByUser);
    Console.WriteLine($"Количество введенных чисел больше 0: {n}");
}
else Console.WriteLine("Ошибка!!! Введены некорректные данные.");

// подсчет натуральных чисел в массиве
int СountNaturalNumbersInArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

// запись чисел от пользователя в массив
int[] ArrayNumberByUser(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

//вывод массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine();
}

// проверка на положительность числа, не включая 0
bool IsNumberPositiv(int x)
{
    return x > 0;
}

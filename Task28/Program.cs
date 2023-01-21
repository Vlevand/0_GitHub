// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 0) Console.WriteLine("Ошибка!!! Введено не натуральное число.");
else
{
    int fnumber = Factorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {fnumber}");
}

int Factorial(int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multiply = multiply * i;
        }
    }
    return multiply;
}
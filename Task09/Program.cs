// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int numb = new Random().Next(10, 100);
Console.WriteLine($"Случайное число от 10 до 99 => {numb}");

// 1 вариант решения: 
// int firstDigit = numb / 10;
// int secondDigit = numb % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра данного числа => {firstDigit}"); else Console.WriteLine($"Наибольшая цифра данного числа => {secondDigit}");

// 2 вариант решения: 
// int firstDigit = numb / 10;
// int secondDigit = numb % 10;
// Console.Write("Наибольшая цифра данного числа => ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// 3 вариант решения: 
// int firstDigit = numb / 10;
// int secondDigit = numb % 10;
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра данного числа => {result}");

int max = MaxDigit(numb);
Console.WriteLine($"Наибольшая цифра данного числа => {max}");

int MaxDigit(int number)
{
int firstDigit = numb / 10;
int secondDigit = numb % 10;
int result = firstDigit > secondDigit ? firstDigit : secondDigit;
return result;
}



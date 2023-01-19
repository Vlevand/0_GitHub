/* Напишите программу, которая будет
1) принимать на вход два числа и
2) выводить, является ли первое число кратным второму.
3) Если число 1 не кратно числу 2, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

string Multiplicity(int numberOne, int numberTwo)
{
    string result;
    if (numberOne % numberTwo == 0)
    {
        result = $"Число {numberOne} кратно числу {numberTwo}";
    }
    else
    {
        result = $"Число {numberOne} не кратно числу {numberTwo}, остаток {numberOne % numberTwo}";
    }
    return result;
}

Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (secondDigit == 0)
{
   Console.WriteLine("Ошибка! Второе число 0.");
}
else
{
   Console.WriteLine(Multiplicity(firstDigit, secondDigit)); 
}


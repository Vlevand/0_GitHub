/* Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

string Multiplicity(int number)
{
    string result;
    if (number % 7 == 0 && number % 23 == 0)
    {
        result = $"Число {number} кратно 7 и 23";
    }
    else
    {
        result = $"Число {number} не кратно одновременно 7 и 23";
    }
    return result;
}

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Multiplicity(digit));
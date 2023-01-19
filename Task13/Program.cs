/* Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int ThirdDigit(int number)
{
    int result = 0;
    if (number < 0) number = -number;
    while (number > 99)
    {
        result = number % 10;
        number = number / 10;    
    }
    return result;
}

int digit = 32679;

if (digit < 100 && digit > -100)
    Console.WriteLine($"В числе {digit} нет третий цифры.");
else Console.WriteLine($"Третье число в числе {digit}: {ThirdDigit(digit)}");

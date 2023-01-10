// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число от 1 до 7 (1 и 7 включая): ");
int WeekDay = Convert.ToInt32(Console.ReadLine());
if (WeekDay >= 1 && WeekDay <= 7)
{
    if (WeekDay == 1) { Console.Write("Понедельник"); }
    else
    {
        if (WeekDay == 2) { Console.Write("Вторник"); }
        else
        {
            if (WeekDay == 3) { Console.Write("Среда"); }
            else
            {
                if (WeekDay == 4) { Console.Write("Четверг"); }
                else
                {
                    if (WeekDay == 5) { Console.Write("Пятница"); }
                    else
                    {
                        if (WeekDay == 6) { Console.Write("Суббота"); }
                        else
                        {
                            Console.Write("Воскресенье"); 
                        }
                    }
                }
            }
        }
    }
}
else
{
    Console.Write("Ошибка! Введенные данные не входят в диапазон от 1 до 7!");
}
/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите номер");
int userNumber = Convert.ToInt32(Console.ReadLine());

string[] DayWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if (userNumber == 1)
    Console.WriteLine(DayWeek[0]);
if (userNumber == 2)
    Console.WriteLine(DayWeek[1]);
if (userNumber == 3)
    Console.WriteLine(DayWeek[2]);
if (userNumber == 4)
    Console.WriteLine(DayWeek[3]);
if (userNumber == 5)
    Console.WriteLine(DayWeek[4]);
if (userNumber == 6)
    Console.WriteLine(DayWeek[5]);
if (userNumber == 7)
    Console.WriteLine(DayWeek[6]);
else Console.WriteLine("В неделе 7 дней!");

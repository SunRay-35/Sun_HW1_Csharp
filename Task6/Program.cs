﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Clear();
Console.WriteLine("Добро пожаловать! Данная программа определит четное число или нет.");
try // В случае ввода значения отличного от целого проинформируем об этом пользователя и завершим работу программы
{
    Console.Write("Введите целое число: ");
    int intA = Convert.ToInt32(Console.ReadLine());
    if (intA % 2 == 0)
    {
        Console.WriteLine($"Число {intA} четное.");
    }
    else
    {
        Console.WriteLine($"Число {intA} нечетное.");
    }
}
catch
{
    Console.WriteLine("Вы ввели некорректное значение, попробуйте запустить программу снова.");
}
finally
{
    Console.WriteLine("Работа программы завершена.");
}
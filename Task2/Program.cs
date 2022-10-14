// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Добро пожаловать! Данная программа сравнивает два целых числа A и B и сообщает, какое из них больше.");
try // В случае ввода значения отличного от целого проинформируем об этом пользователя и завершим работу программы
{
    Console.Write("Введите целое число A: ");
    int intA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число B: ");
    int intB = Convert.ToInt32(Console.ReadLine());
    if (intA == intB) // Сравниваем числа
    {
        Console.WriteLine($"Числа A ({intA}) и B ({intB}) равны.");
    }
    else if (intA > intB)
    {
        Console.WriteLine($"Число A ({intA}) больше числа B ({intB}) на {intA - intB}.");
    }
    else
    {
        Console.WriteLine($"Число A ({intA}) меньше числа B ({intB}) на {intB - intA}.");
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
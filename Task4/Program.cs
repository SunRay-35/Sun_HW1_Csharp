// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.WriteLine("Добро пожаловать! Данная программа сравнивает три целых числа A, B и C и сообщает максимальное значение среди них.");
try // В случае ввода значения отличного от целого проинформируем об этом пользователя и завершим работу программы
{
    int[] arrNumbers = new int[3];
    Console.Write("Введите целое число A: ");
    arrNumbers[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число B: ");
    arrNumbers[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число С: ");
    arrNumbers[2] = Convert.ToInt32(Console.ReadLine());
    
    // Console.WriteLine($"Максимальное значение среди чисел: {arrNumbers[0]}, {arrNumbers[1]} и {arrNumbers[2]} равно {arrNumbers.Max()}."); // Простое решение

    // =========== Решение через цикл ============
    int intMax = arrNumbers[0];
    for (int i = 1; i <3; i++)
    {
        if (arrNumbers[i] > intMax) intMax = arrNumbers[i];
    }
    Console.WriteLine($"Максимальное значение среди чисел: {arrNumbers[0]}, {arrNumbers[1]} и {arrNumbers[2]} равно {intMax}.");
    // ============================================
}
catch
{
    Console.WriteLine("Вы ввели некорректное значение, попробуйте запустить программу снова.");
}
finally
{
    Console.WriteLine("Работа программы завершена.");
}
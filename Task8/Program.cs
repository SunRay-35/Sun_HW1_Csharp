// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Добро пожаловать! Данная программа выведет все четные числа от 1 до введенного целого положительного числа N.");
try // В случае ввода значения отличного от целого проинформируем об этом пользователя и завершим работу программы
{
    Console.Write("Введите целое положительное число N: ");
    int intN = Convert.ToInt32(Console.ReadLine());
    int[] arrEven = new int[] { };
    for (int i = 2; i <= intN; i += 2)
    {
        if (i % 2 == 0)
        {
            Array.Resize(ref arrEven, arrEven.Length + 1);
            arrEven[arrEven.Length - 1] = i;
        }
    }
    string strResult = $"Все четные числа от 1 до {intN}: ";
    foreach (int i in arrEven) strResult = $"{strResult} {i},";
    if (arrEven.Length == 0)
    {
        Console.WriteLine($"При таких условиях программа не смогла определить ни одного четного числа между 1 и {intN}.");
    }
    else
    {
    Console.WriteLine(strResult.TrimEnd(','));
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
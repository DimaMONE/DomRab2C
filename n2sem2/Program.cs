// Задача 13: Выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("Третьей цифры слева нет");
}

else
{
    while (a > 999)
    {
        a = a / 10;
    }
    int d = a % 10 % 10;
    Console.WriteLine($"Третья цифра слева равна {d}");
}

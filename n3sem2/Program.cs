// Выводит четные числа от 1 до N
Console.WriteLine("Привет Тимур");
int i = 1;
for (i = 1; i < 101; i++)
{
    if (i % 15 == 0)
    {
        Console.WriteLine("FIZZ BUZZ");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("FIZZ");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("BUZZ");
    }
    else
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();
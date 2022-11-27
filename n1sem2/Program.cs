//  На вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int square = num / 10 % 10;
Console.WriteLine($" {square}");


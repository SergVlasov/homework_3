// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27 ;  5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter a number from 1: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1)
{
    Console.WriteLine("Wrong. Enter a number from 1: ");
    N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("");
Console.WriteLine($"Success. Cube table from 1 to {N}: ");
int i = 1, result = 0;
while (i <= N)
{
    result = i * i * i;
    Console.WriteLine(result);
    i++;
}
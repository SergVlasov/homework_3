// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Hi. Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
while(number < 10000 | number > 100000)
{
    Console.WriteLine("Wrong. Enter a five-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int n5, n4, n3, n2, n1;
n5 = number % 10;
n4 = number / 10 % 10;
n3 = number / 100 % 10;
n2 = number / 1000 % 10;
n1 = number / 10000;

if ((n1 == n5) && (n2 == n4) && (n3 == n3))
{
    Console.WriteLine("Yes. This number is a palindrome");
}
else
{
    Console.WriteLine("No. This number is not a palindrome");
}
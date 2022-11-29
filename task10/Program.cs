// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 



Console.WriteLine("введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 >= 100 && num1 <= 999);
   

else
{
    Console.WriteLine("число введино неверно");
}
int x1 = num1 / 10;
int x2 = x1 % 10;

Console.WriteLine($"вторая цифра этого числа {x2}");




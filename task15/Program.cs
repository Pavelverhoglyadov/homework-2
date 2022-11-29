//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
Console.WriteLine("понедельник, будни");
else if (num1 == 2)
Console.WriteLine("вторник, будни");
else if (num1 == 3)
Console.WriteLine("среда, будни");
else if (num1 == 4)
Console.WriteLine("четверг, будни");
else if (num1 == 5)
Console.WriteLine("пятницаю, будни");
else if (num1 == 6)
Console.WriteLine("субота, выходной");
else if (num1 == 7)
Console.WriteLine("воскресенье, выходной");
else 
Console.WriteLine("неверное число");
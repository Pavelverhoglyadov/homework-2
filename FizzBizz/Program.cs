for (int i = 1; i < 101; i++)
    if (i% 3 == 0 && i% 6 == 0)
        Console.WriteLine("FizzBizz");
    else if (i% 3 == 0)
        Console.WriteLine("Fizz");
    else if (i% 5 == 0)
        Console.WriteLine("Buzz");
    else Console.WriteLine(i);

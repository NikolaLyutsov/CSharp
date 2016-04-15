//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g.N = 100000.

using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int zeroCounter = 0;
        int divider = 5;
        while (n / divider >= 1)
        {
            zeroCounter += n / divider;
            divider *= 5;
        }
        Console.WriteLine(zeroCounter);
        }
    }

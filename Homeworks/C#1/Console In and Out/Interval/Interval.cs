//Write a program that reads two positive integer numbers N and M and prints how 
//many numbers exist between them such that the reminder of the division by 5 is 0.

using System;

    class Interval
    {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = n + 1; i < m ; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    }

//Write a program that reads from the console a positive integer number N and prints a matrix like in 
//the examples below.Use two nested loops.

    using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int k = 1; k <= n; k++)
            {
                Console.Write("{0} ", i + k);
            }

            Console.WriteLine();
        }
        }
    }

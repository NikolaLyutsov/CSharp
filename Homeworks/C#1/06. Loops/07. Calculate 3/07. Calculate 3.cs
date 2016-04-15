//elements(also known as the number of combinations) is calculated by the following formula: formula
// For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.Your task 
//is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

//Try to use only two loops.

using System;
using System.Numerics;

    class Program
    {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger result = (Getfactorial(n)) / (Getfactorial(k) * Getfactorial(n - k));
        Console.WriteLine(result);
    }

        private static BigInteger Getfactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Getfactorial(n - 1);
    }
    }

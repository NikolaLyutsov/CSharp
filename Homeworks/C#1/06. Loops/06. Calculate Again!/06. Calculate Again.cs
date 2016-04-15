//Write a program that calculates N! / K! for given N and K.
//Use only one loop.

using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger Nfactorial = Getfactorial(n);
        BigInteger Kfactorial = Getfactorial(k);
        BigInteger result = Nfactorial / Kfactorial;
        Console.WriteLine(result);
    }
    private static BigInteger Getfactorial (int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n * Getfactorial(n - 1);
    }
    }

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the Nth Catalan number by given N

using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = Getfactorial(2 * n) / (Getfactorial(n + 1) * Getfactorial(n));
        Console.WriteLine(result); 
     }
    private static BigInteger Getfactorial (int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Getfactorial(n - 1);
    }
    }

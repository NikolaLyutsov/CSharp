//Write a program that finds all prime numbers in the range[1...N]. 
//Use the Sieve of Eratosthenes algorithm.The program should print the biggest prime
//number which is <= N.

using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        var isPrime = new int[n + 1];
        var result = 0;

        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i] == 0)
            {
                result = i;

                for (int j = i * 2; j <= n; j += i)
                {
                    isPrime[j] = 1;
                }
            }
        }
        Console.WriteLine(result);
        }
    }

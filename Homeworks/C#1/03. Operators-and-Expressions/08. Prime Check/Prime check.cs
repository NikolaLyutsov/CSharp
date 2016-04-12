//Write a program that reads an integer N(which will always be less than 100 or equal) and uses an expression
//to check if given N is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

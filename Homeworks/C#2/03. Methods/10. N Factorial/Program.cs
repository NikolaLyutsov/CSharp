//Write a method that multiplies a number represented as an array of digits by a given integer number.Write a program to calculate N!.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static BigInteger Factoriel(int n)
        {
            BigInteger product = 1;
            for (int i = 1; i <= n; i++)
            {
                product = product * i;
            }
            if (product <=1)
            {
                return 1;
            }
            else
            {
                return product;
            }
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }
    }
}

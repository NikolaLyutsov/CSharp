//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.Use variable number of arguments.
//Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Integer_calculations
{
    class Program
    {
        static int Minimum(int[] array)
        {
            int result = 0;
            result = array.Min();
            return result;
        }
        static int MAximum(int[] array)
        {
            int result1 = 0;
            result1 = array.Max();
            return result1;
        }

        static double Average(int[] array)
        {
            double result2 = 0;
            result2 = array.Average();
            return result2;
        }

        static int Sum(int[] array)
        {
            int result3 = 0;
            result3 = array.Sum();
            return result3;
        }

        static BigInteger Product(int[] array)
        {
            BigInteger result4 = 1;
            foreach (var num in array)
            {
                result4 = result4 * num;
            }
            return result4;
        }

        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Minimum(array));
            Console.WriteLine(MAximum(array));
            Console.WriteLine("{0:0.00}", Average(array));
            Console.WriteLine(Sum(array));
            Console.WriteLine(Product(array));
        }
        
    }
}

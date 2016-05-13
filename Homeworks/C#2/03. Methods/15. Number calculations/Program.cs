//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Number_calculations
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

        static int Product(int[] array)
        {
            int result4 = 1;
            foreach (var num in array)
            {
                result4 = result4 * num;
            }
            return result4;
        }

        static void Main()
        {
            int[] array = { 1, 34, 432, 2, 1 };
            Console.WriteLine(Minimum(array));
            Console.WriteLine(MAximum(array));
            Console.WriteLine("{0:0.00}", Average(array));
            Console.WriteLine(Sum(array));
            Console.WriteLine(Product(array));
            
        }

    }
}

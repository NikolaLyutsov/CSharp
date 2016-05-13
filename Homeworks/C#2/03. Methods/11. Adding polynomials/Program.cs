//Write a method that adds two polynomials.Represent them as arrays of their coefficients.
//Write a program that reads two polynomials and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static int[] PolynominalsAdding(int[] array1, int[] array2,int n)
        {
            int[] array3 = new int[n];
            for (int i = 0; i < n; i++)
            {
                    array3[i] = array1[i] + array2[i];
            }
            return array3;
        }
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var array3 = PolynominalsAdding(array1, array2, n);
            Console.WriteLine(String.Join(" ", array3));
        }
    }
}

//Write a method that counts how many times given number appears in a given array.
//Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static int Function(int x, int[] array)
        {
            int counter = 0;
            foreach (int a in array)
            {
                if (a == x)
                {
                    counter++;
                }
                
            }
            return counter;
        }
        static void Main()
        {
            Console.ReadLine();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Function(x, array));
        }
    }
}

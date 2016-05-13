//Write a method that returns the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {

        static void SortArrays(decimal[] array)
        {
                Array.Sort(array);
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal[] array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            SortArrays(array);
            Console.WriteLine(string.Join(" ",array));
        }
    }
}

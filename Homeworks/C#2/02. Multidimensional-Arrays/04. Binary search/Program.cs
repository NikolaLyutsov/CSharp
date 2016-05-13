//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            int result = Array.BinarySearch(array, k);

            if (result == -1)
            {
                Console.WriteLine("No result, {0} is the smallest element", k);
            }
            else if(result < -1)
            {
                Console.WriteLine("Largest element -> {0}", k);
            }
            else
            {
                Console.WriteLine("Exact Match {0}",k);
            }
        }
    }
}

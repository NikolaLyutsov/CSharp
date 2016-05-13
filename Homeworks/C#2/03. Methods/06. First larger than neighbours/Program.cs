//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static int FirstLargerNeighbour(int[] array)
        {
            int num = 0;
            int result = 0;
            for (int i = 1; i < array.Length -1; i++)
            {
                if (array[i] > array[i-1] && array[i] > array[i+1])
                {
                    num = array[i];
                    break;
                }
            }
            result = Array.IndexOf(array, num);
            return result;
        }
        static void Main()
        {
            Console.ReadLine();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(FirstLargerNeighbour(array));
        }
    }
}

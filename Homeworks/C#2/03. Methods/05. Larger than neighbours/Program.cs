//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
//Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
    static int LargerInt(int[] array)
    {
        int counter = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i-1] && array[i] > array[i + 1])
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
        Console.WriteLine(LargerInt(array));
        }
    }

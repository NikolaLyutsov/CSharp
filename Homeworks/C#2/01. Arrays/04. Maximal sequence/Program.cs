//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

using System;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int count = 1;
            int lengthCount = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    count++;
                    lengthCount = Math.Max(lengthCount, count);
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(lengthCount);
        }
    }
}

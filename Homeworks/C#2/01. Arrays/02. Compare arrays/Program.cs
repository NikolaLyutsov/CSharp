//Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            bool isEqual = false;
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (array1[i] == array2[i])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            }
        }
    }
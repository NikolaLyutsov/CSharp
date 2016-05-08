//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());
       
        index = Array.BinarySearch(array, x);
        if (index > -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine(-1);
        }
        
        }
    }
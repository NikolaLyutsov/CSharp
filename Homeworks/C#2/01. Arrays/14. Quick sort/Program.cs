//Write a program that sorts an array of integers using the Quick sort algorithm

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
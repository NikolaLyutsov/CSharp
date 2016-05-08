//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxSum = int.MinValue;
        int currSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            currSum += arr[i];
            if (currSum > maxSum)
            {
                maxSum = currSum;
            }
            if (currSum <0)
            {
                currSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}

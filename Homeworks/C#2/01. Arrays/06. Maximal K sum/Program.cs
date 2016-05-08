//Write a program that reads two integer numbers N and K and an array of N 
//elements from the console. Find the maximal sum of K elements in the array.

using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
        Array.Sort(nums);
        Array.Reverse(nums);
        int result = 0;

        for (int i = 0; i < k; i++)
        {
            result += nums[i];
        }
        Console.WriteLine(result);
            
    }
}

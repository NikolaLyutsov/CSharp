//Write a program that finds the length of the maximal increasing sequence in an array of N integers.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;
        int lengthcounter = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
            {
                counter++;
            }
            else
            {
                if (counter > lengthcounter)
                {
                    lengthcounter = counter;
                }
                counter = 1;
            }
        }
        if (counter > lengthcounter)
        {
            lengthcounter = counter;

        }
        Console.WriteLine(lengthcounter);
    }
}

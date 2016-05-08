//Write a program that finds the most frequent number in an array of N elements.

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
        int specialNumberIndex = 0;
        int currentNumTimes = 0;
        int specialNumberNumTimes = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    currentNumTimes++;
                }
            }
            if (currentNumTimes > specialNumberNumTimes)
            {
                specialNumberIndex = i;
                specialNumberNumTimes = currentNumTimes;
            }
            currentNumTimes = 0;
        }
        Console.WriteLine("{0} ({1} times)",array[specialNumberIndex], specialNumberNumTimes);
    }
}
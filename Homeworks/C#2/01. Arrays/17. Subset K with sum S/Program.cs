//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
    {
        static void Main()
        {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        var sum = 14;
        var k = 4;

        var isSumExist = false;
        var length = arr.Length;
        var counter = 0; 
        List<int> subset = new List<int>();
        
        int maxConbinations = (int)Math.Pow(2, length) - 1;

        for (int i = 1; i <= maxConbinations; i++)
        {
            long currentsum = 0;
            counter = 0;
            subset = new List<int>();

            for (int j = 0; j < length; j++)
            {
                int mask = 1 << j;
                int bit = (mask & i) >> j;

                if (bit == 1)
                {
                    currentsum += arr[j];
                    subset.Add(arr[j]);
                    counter++;
                }
            }

            if (currentsum == sum && counter == k)
            {
                isSumExist = true;
                break;
            }
        }

        var output = isSumExist ? "yes" : "no";
        Console.WriteLine(output);
        Console.WriteLine(string.Join(", ", subset));
    }
    }

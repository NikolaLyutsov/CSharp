//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array
//is sorted in increasing order.Print the minimal number of elements that need to be removed in order for the array to become sorted.

using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = ReadNums(n);
            int maxSortedNums = FindMaxSortedNums(nums);
            Console.WriteLine(nums.Count - maxSortedNums);
        }

        private static int FindMaxSortedNums(List<int> nums)
        {
            int[] sortedNumsCount = Enumerable.Repeat(1, nums.Count).ToArray();

            int maxSortedNums = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] >= nums[j] && sortedNumsCount[i] <= sortedNumsCount[j] + 1)
                    {
                        sortedNumsCount[i] = sortedNumsCount[j] + 1;
                        if (maxSortedNums < sortedNumsCount[i])
                        {
                            maxSortedNums = sortedNumsCount[i];
                        }
                    }
                }
            }

            return maxSortedNums;
        }

        private static List<int> ReadNums(int n)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            return nums;
        }
    }
}
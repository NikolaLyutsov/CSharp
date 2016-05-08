//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Find_Sum_In_Array
{
    class FindSumInArray
    {
        static void Main()
        {
            int inputSum = int.Parse(Console.ReadLine());
            
            int sizeN = int.Parse(Console.ReadLine());
            
            int[] inputArray = new int[sizeN];

            for (int i = 0; i < sizeN; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            
            var findTheSum =
                
                from startAt in Enumerable.Range(0, inputArray.Length)
                from length in Enumerable.Range(1, inputArray.Length - startAt)

                let SubSequence = inputArray.Skip(startAt).Take(length)

                orderby SubSequence.Count() descending
                where SubSequence.Sum() == inputSum
                select SubSequence;

            var ResultSubseq = findTheSum.First();


            foreach (var value in ResultSubseq)
            {
                Console.Write(value.ToString() + " ");
            }

            Console.Write(ResultSubseq.Sum());

        }
    }
}
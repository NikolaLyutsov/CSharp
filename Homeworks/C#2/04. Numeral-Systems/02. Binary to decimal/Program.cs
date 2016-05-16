//Write a program that converts a binary number N to its decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static BigInteger BinaryToDecimal(string binary)
        {
            BigInteger sum = 0;
            foreach (char bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }
            return sum;
        }
        static void Main()
        {
            string binary = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binary));
        }
    }
}

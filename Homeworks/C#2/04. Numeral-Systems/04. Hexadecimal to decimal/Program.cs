//Write a program that converts a hexadecimal number N to its decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        public static Dictionary<char, BigInteger> HexToDecimal = new Dictionary<char, BigInteger>()
        {
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'A', 10},
        {'B', 11},
        {'C', 12},
        {'D', 13},
        {'E', 14},
        {'F', 15}
        };

        public static BigInteger HexDigitoDec(string nValue, int n)
        {
            BigInteger sum = 0;
            foreach (char digit in nValue)
            {
                sum = HexToDecimal[digit] + sum * n;
            }
            return sum;
        }
        static void Main()
        {
            string num = Console.ReadLine();
            Console.WriteLine(HexDigitoDec(num, 16));
        }
    }
}
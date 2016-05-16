//Write a program that converts a decimal number N to its binary representation.

using System;
using System.Numerics;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static string DecimalToAnything(int decValue, int baseValue)
        {
            string result = "";
            do
            {
                int reminder = decValue % baseValue;
                result = reminder + result;
                decValue /= baseValue;
            } while (decValue > 0);
            return result;
        }
        static void Main()
        {
            int decValue = int.Parse(Console.ReadLine());
            string result = string.Empty;
            if (decValue < 0)
            {
                result += "1";
                int temp = decValue + 1;
                result += DecimalToAnything(short.MaxValue + temp, 2).PadLeft(15, '0');
            }
            else
            {
                result += "0";
                result += DecimalToAnything(decValue, 2).PadLeft(15, '0');
            }
            Console.WriteLine(result);
        }
    }
}

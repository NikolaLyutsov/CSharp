//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static long BinaryToDecimal(string binary)
        {
            long sum = 0;
            foreach (char bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }
            return sum;
        }
        static string DecimalToHex(long decValue)
        {
            string result = "";
            char[] hexDigits = "0123456789ABCDEF".ToCharArray();
            do
            {
                long value = decValue % 16;
                result = hexDigits[value] + result;
                decValue /= 16;
            } while (decValue != 0);
            return result;
        }
        static void Main()
        {
            string binary = Console.ReadLine();
            long binaryToDecimall = 0;
            binaryToDecimall = BinaryToDecimal(binary);
            Console.WriteLine(DecimalToHex(binaryToDecimall));
        }
    }
}

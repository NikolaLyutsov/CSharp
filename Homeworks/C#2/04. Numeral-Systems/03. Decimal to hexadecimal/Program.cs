//Write a program that converts a decimal number N to its hexadecimal representation.

using System;
namespace _03.Decimal_to_hexadecimal
{
    class Program
    {

        static string DecimalToHex(long decValue)
        {
            string result = "";
            char[] hexDigits = "0123456789ABCDEF".ToCharArray();
            do
            {
                long value = decValue % 16;
                result = hexDigits[value] + result;
                decValue /= 16;
            } while (decValue !=0);
            return result;
        }
        static void Main()
        {
            long decValue = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(decValue));
        }
    }
}

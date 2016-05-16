//Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_short
{
    class Program
    {

        static string DecimalToBinary(ushort decValue)
        {
            string binary = "";
            while (decValue != 0)
            {
                ushort bit = (ushort)(decValue % 2);
                binary = bit + binary;
                decValue /= 2;
            }
            return binary;
        }
        static void Main()
        {
            ushort decValue = ushort.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(decValue).PadLeft(16, '0'));
        }
    }
}

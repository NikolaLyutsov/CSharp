//Write a method that reverses the digits of a given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static string ReverseDigits(string num)
        {
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main()
        {
            string num = Console.ReadLine();
            Console.WriteLine(ReverseDigits(num));
        }
    }
}

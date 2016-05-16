//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static Dictionary<char, string>Hexbin = new Dictionary<char, string>()
            {
        {'0', "0000"},
        {'1', "0001"},
        {'2', "0010"},
        {'3', "0011"},
        {'4', "0100"},
        {'5', "0101"},
        {'6', "0110"},
        {'7', "0111"},
        {'8', "1000"},
        {'9', "1001"},
        {'A', "1010"},
        {'B', "1011"},
        {'C', "1100"},
        {'D', "1101"},
        {'E', "1110"},
        {'F', "1111"}
        };
        static string HexToBinarry(string hex)
        {
            string result = "";
            foreach (char hexDigit in hex)
            {
                result += Hexbin[hexDigit];
            }
            return result;
        }

        static void Main()
        {
            string num = Console.ReadLine();
            Console.WriteLine(HexToBinarry(num).TrimStart('0'));
        }
    }
}

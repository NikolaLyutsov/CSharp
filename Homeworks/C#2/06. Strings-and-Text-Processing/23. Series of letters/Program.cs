//Write a program that reads a string from the console and replaces all 
//series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(RemoveCharacters(input));
        }
        private static string RemoveCharacters(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (i+1<input.Length && input[i-1] == input[i])
                {
                    continue;
                }
                result.Append(input[i - 1]);
                if(i+1 != input.Length || input[i - 1] == input[i])
                {
                    continue;
                }

                result.Append(input[i]);
                break;
            }
            return result.ToString();
        }
        
    }
}

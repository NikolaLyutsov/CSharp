//Write a program that reads a string, reverses it and prints the result on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_string
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Reverse().ToArray());
        }
    }
}

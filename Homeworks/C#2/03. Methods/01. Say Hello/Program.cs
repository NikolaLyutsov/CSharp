//Write a method that asks the user for his name and prints Hello, <name>!. 
//Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static string Hello(string input)
        {
            return string.Format("Hello, {0}!", input);
        }
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Hello(input));
        }
        
    }

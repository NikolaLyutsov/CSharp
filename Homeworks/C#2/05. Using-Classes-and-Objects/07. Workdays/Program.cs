//Write a method that calculates the number of workdays between today and a given 
//date, passed as parameter. Consider that workdays are all days from Monday to 
//Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Workdays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine
                (
                    Console.ReadLine()
                           .Trim(' ')
                           .Split(' ')
                           .Select(int.Parse)
                           .ToList()
                           .Sum()
                );
        }
    }
}

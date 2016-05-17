//Write a program that generates and prints to the console 10 random values in
//the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Random_numbers
{
    class Program
    {
        static void Main()
        {
            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.Next(100, 200));
            }
        }
    }
}

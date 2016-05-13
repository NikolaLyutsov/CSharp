//Write a method that returns the last digit of given integer as an English word. 
//Write a program that reads a number and prints the result of the method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class Program
    {
        static string EnglishWord(int a)
        {
            switch (a %10)
            {
                case 1:return "one";
                case 2:return "two";
                case 3:return "three";
                case 4:return "four";
                case 5:return "five";
                case 6:return "six";
                case 7:return "seven";
                case 8:return "eight";
                case 9:return "nine";
                default: return "zero";
            }
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(EnglishWord(a));



                }
    }
}

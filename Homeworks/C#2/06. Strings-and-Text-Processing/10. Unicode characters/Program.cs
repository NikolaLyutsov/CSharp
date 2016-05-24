//Write a program that converts a string to a sequence of C# Unicode 
//character literals.

using System;

namespace _2.Reverse_string
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(GetSequence(input[i]));
            }
            Console.WriteLine();
        }
        static string GetSequence(char a)
        {
            return "\\u" + ((int)a).ToString("X4");
        }
    }
}

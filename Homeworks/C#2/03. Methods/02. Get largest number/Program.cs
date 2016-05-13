//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
    static int GetMax(int a, int b)
    {
        int result = 0;
        result = Math.Max(a, b);
        return result;
    }

        static void Main()
        {
        int numbers = 0;
        int end = 0;
        string input = Console.ReadLine();
        string[] inputs = input.Trim(' ').Split(' ');
        int input1 = int.Parse(inputs[0]);
        int input2 = int.Parse(inputs[1]);
        int input3 = int.Parse(inputs[2]);
        numbers = GetMax(input1, input2);
        end = GetMax(numbers, input3);
        Console.WriteLine(end);
    }
    }

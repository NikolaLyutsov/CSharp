//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

    class Program
    {
        static void Main()
        {
        string numberToBinary = Console.ReadLine().Trim();
        double number = 0;
        double power = 0;

        for (int i = numberToBinary.Length - 1; i >= 0; i--)
        {
            number += (numberToBinary[i] - '0') * Math.Pow(2, power);
            power++;
        }
        Console.WriteLine(number);
        }
    }

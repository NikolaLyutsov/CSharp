//Write a program that gets two numbers from the console and prints the 
//greater of them.

using System;

    class Program
    {
        static void Main()
        {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(A,B));
    }
    }

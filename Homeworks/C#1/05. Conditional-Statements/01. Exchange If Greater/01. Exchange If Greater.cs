//Write a program that reads two double values from the console A and B, 
//stores them in variables and exchanges their values if the first one is greater
//than the second one.Use an if-statement.As a result print the values of the 
//variables A and B, separated by a space.

using System;

    class Program
    {
        static void Main()
        {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        if (A == B)
        {
            Console.WriteLine("{0} {1}", A, B);
        }
        else if (A > B)
        {
            Console.WriteLine("{0} {1}", B, A);
        }
        else
        {
            Console.WriteLine("{0} {1}",A, B);
        }
        }
    }

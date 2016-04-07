//Write a program that reads an integer N from the console and prints true if the third digit 
//of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
//The counting is done from right to left, meaning 123456's third digit is 4.

using System;

    class Program
    {
        static void Main()
        {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        bool isSeven = (n / 100) % 10 == 7;
        double num = (n / 100) % 10;
        Console.WriteLine(isSeven? ("true") : ("false " + num));
        }
    }

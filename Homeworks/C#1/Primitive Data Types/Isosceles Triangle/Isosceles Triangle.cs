//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

using System;

    class Program
    {
        static void Main()
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string a = @"
   ©

  © ©

 ©   ©

© © © ©";
            Console.WriteLine(a);
           
        }
    }

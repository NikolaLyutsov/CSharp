//Write a program that reads an integer from the console, uses an expression to 
//check if given integer is odd or even, and prints "even NUMBER" or "odd NUMBER",
//where you should print the input number's value instead of NUMBER.

using System;

    class TEST
    {
        static void Main ()
        {
        int num = int.Parse(Console.ReadLine());
        bool IsEven = num % 2 == 0;
        Console.WriteLine(IsEven? ("even " + num) : ("odd " + num));
        }
    }

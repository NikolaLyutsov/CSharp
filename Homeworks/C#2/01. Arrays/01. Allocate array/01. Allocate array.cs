//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained 
//array on the console.

using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        string [] array = new string[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(i * 5);
        }
    }
    }

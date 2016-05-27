//Write a program that reads an integer number and calculates and prints its
//square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.Use try-catch-finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    static class Program
    {
        static void Main()
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(a);
            if (double.IsNaN(result))
            {
                throw new System.Exception();
            }
            else
            {
                Console.WriteLine("{0:F3}", result);
            }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
}

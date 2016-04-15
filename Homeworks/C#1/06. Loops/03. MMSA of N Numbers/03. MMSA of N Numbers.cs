//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).
//The input starts by the number N(alone in a line) followed by N lines, each holding an integer number.
//The output is like in the examples below.

using System;

class problem
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        double avg = 0;
        for (int i = 0; i < n; i++)
        {
            double gurrentNumber = double.Parse(Console.ReadLine());
            sum += gurrentNumber;
            if (gurrentNumber > max)
            {
                max = gurrentNumber;
            }
            if (gurrentNumber < min)
            {
                min = gurrentNumber;
            }
        }
        avg = sum / n;
        Console.WriteLine("min={0:0.00}",min);
        Console.WriteLine("max={0:0.00}",max);
        Console.WriteLine("sum={0:0.00}",sum);
        Console.WriteLine("avg={0:0.00}",avg);
    }
}

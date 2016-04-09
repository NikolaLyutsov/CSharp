//Write a program that reads from the console the radius r of a circle and prints its
//perimeter and area, rounded and formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class Program
    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI *r;
        double area = Math.PI * r * r;
        Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
    }
    }

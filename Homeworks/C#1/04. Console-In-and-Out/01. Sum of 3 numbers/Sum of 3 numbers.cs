﻿//Write a program that reads 3 real numbers from the console and 
//prints their sum.

using System;
using System.Globalization;
using System.Threading;

class Program
 {
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine(a + b + c);
    }
 }

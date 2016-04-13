//Write a program that finds the biggest of three numbers that are read from the console.

using System;
class Program
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double s = firstNumber;
        if (firstNumber < secondNumber)
        {
            s = secondNumber;
        }
        if (s < thirdNumber)
        {
            s = thirdNumber;
        }
        Console.WriteLine(s);
    }
}



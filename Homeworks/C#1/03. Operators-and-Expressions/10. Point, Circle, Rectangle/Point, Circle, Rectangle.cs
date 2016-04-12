//Write a program that reads a pair of coordinates x and y and uses an expression
//to checks for given point(x, y) if it is within the circle K({ 1, 1}, 1.5) and 
//out of the rectangle R(top= 1, left= -1, width= 6, height= 2).

using System;

    class Program
    {
        static void Main()
        {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (Math.Pow(x-1,2) + Math.Pow(y-1,2) <=1.5*1.5) ;
        bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if(isInCircle)
        {
            Console.Write("inside circle ");
        }
        else 
        {
            Console.Write("outside circle ");
        }

        if(isInRectangle)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
    }

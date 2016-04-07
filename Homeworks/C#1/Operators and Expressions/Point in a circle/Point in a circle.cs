//Write a program that reads the coordinates of a point x and y and using an expression checks
//if given point(x, y) is inside a circle K({ 0, 0}, 2) - the center has coordinates(0, 0)
//and the circle has radius 2. The program should then print "yes DISTANCE" if the point 
//is inside the circle or "no DISTANCE" if the point is outside the circle.
//In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.

using System;

    class Program
    {
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt(x * x + y * y);
        if (distance > 2)
        {
            Console.WriteLine("no {0:F2}",distance);
        }
        else
        {
            Console.WriteLine("yes {0:F2}",distance);
        }
    }
    }

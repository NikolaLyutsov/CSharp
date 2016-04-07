//Write an expression that calculates rectangle’s area and perimeter by given width and height.
//The width and height should be read from the console.

using System;

    class Rectangles
    {
        static void Main()
        {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double Area = width * height;
        double Perimeter = (2 * width) + (2 * height);
        Console.WriteLine(" {0:F2} {1:F2}", Area , Perimeter);
    }
    }

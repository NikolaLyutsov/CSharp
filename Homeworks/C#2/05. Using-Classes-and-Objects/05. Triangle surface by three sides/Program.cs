//Write program that calculates the surface of a triangle by given its three sides.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main()
        {
            double a, b, c;

            double halfP =
                (((a = double.Parse(Console.ReadLine())) +
                (b = double.Parse(Console.ReadLine())) +
                (c = double.Parse(Console.ReadLine()))) / 2);
            Console.WriteLine(
                Math.Sqrt
                (
                    halfP *
                    (halfP - a) *
                    (halfP - b) *
                    (halfP - c)
                ).ToString("0.00")
                );
        }
    }
}

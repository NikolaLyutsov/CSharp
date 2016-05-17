//Write program that calculates the surface of a triangle by given a side and an 
//altitude to it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = 0;
            result = (side / 2) * height;
            Console.WriteLine("{0:0.00}", result);
        }
    }
}

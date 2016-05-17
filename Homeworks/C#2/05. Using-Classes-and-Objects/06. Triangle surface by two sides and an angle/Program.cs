//Write program that calculates the surface of a triangle by given two sides
//and an angle between them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine
                (
                    (double.Parse(Console.ReadLine()) *
                     double.Parse(Console.ReadLine()) *
                     (Math.Sin
                        (
                            double.Parse(Console.ReadLine()) *
                            Math.PI / 180
                        )
                        / 2)
                    )
                    .ToString("F2")
                );
        }
    }
}

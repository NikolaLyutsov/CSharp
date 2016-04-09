//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it(prints its real roots).

//using System;

//    class Program
//    {
//        static void Main()
//        {
//        double a = double.Parse(Console.ReadLine());
//        double b = double.Parse(Console.ReadLine());
//        double c = double.Parse(Console.ReadLine());
//    }
//    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("{0:0.00}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("{0:0.00}\n{1:0.00}", x2, x1);
            }
        }
    }
}
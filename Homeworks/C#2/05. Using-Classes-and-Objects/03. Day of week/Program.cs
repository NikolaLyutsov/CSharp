//Write a program that prints to the console which day of the week is today. 
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Day_of_week
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Today.DayOfWeek.ToString());
        }
    }
}

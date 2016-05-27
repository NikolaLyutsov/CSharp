//Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end ).
//If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program 
//that enters 
//10 numbers: a1, a2, ..., a10, such that 0 < a1< ... < a10< 100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_numbers
{
    class Program
    {
        static void Main()
        {
            var start = 1;
            var end = 100;
            ReadNumber(start, end);
        }
        static void ReadNumber(int start, int end)
        {
            string exceptionMessage = "Exception";

            var elementsToAdd = 10;

            var join = " < ";
            var output = new StringBuilder();
            var prevNum = start;

            output.Append(start);
            output.Append(join);
            for (int i = 0; i < elementsToAdd; i++)
            {
                try
                {
                    var numberAdd = int.Parse(Console.ReadLine());
                    if (prevNum < numberAdd)
                    {
                        output.Append(numberAdd);
                        output.Append(join);
                    }
                    else
                    {
                        throw new Exception(exceptionMessage);
                    }
                    prevNum = numberAdd;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            output.Append(end);
            Console.WriteLine(output);
        }
    }
}

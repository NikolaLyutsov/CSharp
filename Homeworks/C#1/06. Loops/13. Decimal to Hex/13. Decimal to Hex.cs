//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

    class Program
    {
        static void Main()
        {
        long decimalNumber = long.Parse(Console.ReadLine());

        string hexNumber = "";
        while (decimalNumber != 0)
        {
            long remainder = decimalNumber % 16;

            switch (remainder)
            {
                case 10:
                    hexNumber = "A" + hexNumber;
                    break;
                case 11:
                    hexNumber = "B" + hexNumber;
                    break;
                case 12:
                    hexNumber = "C" + hexNumber;
                    break;
                case 13:
                    hexNumber = "D" + hexNumber;
                    break;
                case 14:
                    hexNumber = "E" + hexNumber;
                    break;
                case 15:
                    hexNumber = "F" + hexNumber;
                    break;
                default:
                    hexNumber = remainder + hexNumber;
                    break;
            }
            decimalNumber /= 16;
            }
        Console.WriteLine(hexNumber);
        }
    }

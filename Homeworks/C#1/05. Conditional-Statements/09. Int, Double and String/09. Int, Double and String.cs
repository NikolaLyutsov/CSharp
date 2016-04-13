//Write a program that, depending on the first line of the input, reads an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.

using System;

    class Program
    {
        static void Main()
        {
        string num = Console.ReadLine();
        switch (num)
        {
            case "integer":
                Double intNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case "real":
                double realNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",realNumber + 1);
                break;
            case "text":
                string text = Console.ReadLine();
                Console.WriteLine(text +"*");
                break;
            default:
                break;
        }
    }
    }

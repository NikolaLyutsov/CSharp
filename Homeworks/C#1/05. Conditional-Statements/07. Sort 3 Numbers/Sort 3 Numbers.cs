//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.

using System;

    class Program
    {
        static void Main()
        {
        int firstNumber =  int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber =  int.Parse(Console.ReadLine());
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            if (secondNumber >= thirdNumber)
            {
                Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
            }
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
            }
            else
            {
                Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
            }
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
            }
        }
        }
     }

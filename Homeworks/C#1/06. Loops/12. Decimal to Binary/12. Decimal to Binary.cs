//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        long inputNumber = long.Parse(Console.ReadLine());
        StringBuilder binary = new StringBuilder();
        if (inputNumber == 0)
        {
            binary.Append('0');
        }
        while (inputNumber > 0)
        {

            binary.Append((inputNumber % 2).ToString());
            inputNumber /= 2;
        }
        StringBuilder result = new StringBuilder();
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            result.Append(binary[i]);
        }
        Console.WriteLine(result.ToString());
    }
}

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.


using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();

        long result = 0;
        long power = 1;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            int number = 0;
            switch (input[i])
            {
                case 'A': number = 10; break;
                case 'B': number = 11; break;
                case 'C': number = 12; break;
                case 'D': number = 13; break;
                case 'E': number = 14; break;
                case 'F': number = 15; break;
                default: number = input[i] - '0'; break;
            }
            result += power * number;
            power *= 16;
        }
        Console.WriteLine(result);
    }
}
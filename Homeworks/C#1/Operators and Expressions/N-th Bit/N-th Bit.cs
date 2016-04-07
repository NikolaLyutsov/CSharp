//Write a program that reads from the console two integer numbers P and N and prints on the console 
//the value of P's N-th bit.

using System;

class Program
{
    static void Main()
    {
        string stN = Console.ReadLine();
        long n = long.Parse(stN);
        string stP = Console.ReadLine();
        int p = int.Parse(stP);
        byte bitAtPositionP = (byte)((n >> p) & 1);
        Console.WriteLine("{0}", bitAtPositionP);
    }      
}

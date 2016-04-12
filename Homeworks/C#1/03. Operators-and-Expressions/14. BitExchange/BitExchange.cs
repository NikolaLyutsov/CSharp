//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned
//integer(read from the console)

using System;

class Program
{

    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;
        uint firstBits = (n & (mask << 3))>>3;
        uint secondBits = (n & (mask << 24)) >> 24;
        n = n & ~(mask << 3);
        n = n & ~(mask << 24);
        n = n | (firstBits << 24);
        n = n | (secondBits << 3);
        Console.WriteLine(n);


    }
}

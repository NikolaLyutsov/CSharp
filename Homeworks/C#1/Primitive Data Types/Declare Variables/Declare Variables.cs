//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
//52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it.
//Try to compile the code.


using System;

    class Program
    {
        static void Main()
        {
        long a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        int e = -10000;
        Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
        }
    }

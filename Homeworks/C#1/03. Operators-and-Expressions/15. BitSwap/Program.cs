//Write a program first reads 3 numbers n, p, q and k and than swaps bits { p, p+1, …, p+k-1}
//with bits { q, q+1, …, q+k-1}
//of n.Print the resulting integer on the console.

using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        for (int i = p; i <= p + k - 1; i++)
        {
            int mask = 1;
            int bitQ = (n & (mask << q)) >> q;
            int bitP = (n & (mask << i)) >> i;
            n = n & ~(mask << i);
            n = n & ~(mask << q);
            n = n | (bitP << q);
            n = n | (bitQ << i);
            q++;
        }
        Console.WriteLine(n);
    }
    }

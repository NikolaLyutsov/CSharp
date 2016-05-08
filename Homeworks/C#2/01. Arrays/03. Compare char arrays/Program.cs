//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
public class CompareCharArrays
{
    private static void Main()
    {
        string charArr1 = Console.ReadLine();
        string charArr2 = Console.ReadLine();

        for (int i = 0; i < Math.Min(charArr1.Length, charArr2.Length); i++)
        {
            if (charArr1[i] < charArr2[i])
            {
                Console.WriteLine("<");
                return;
            }
            else if (charArr1[i] > charArr2[i])
            {
                Console.WriteLine(">");
                return;
            }
        }

        if (charArr1.Length == charArr2.Length)
        {
            Console.WriteLine("=");
        }
        else if (charArr1.Length < charArr2.Length)
        {
            Console.WriteLine("<");
        }
        else if (charArr1.Length > charArr2.Length)
        {
            Console.WriteLine(">");
        }
    }
}
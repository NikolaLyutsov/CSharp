//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class Program
{
        static void Main()
        {
        string first = Console.ReadLine();
        char[] firstArray = first.ToCharArray();
        string second = Console.ReadLine();
        char[] secondArray = second.ToCharArray();
        int count = 0;
            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("<");
                    break;
                }
                if (firstArray.Length == count)
                {
                    Console.WriteLine("=");
                }
            }
            }
            
    }
}
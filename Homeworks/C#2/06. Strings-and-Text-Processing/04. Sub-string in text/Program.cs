//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        int counter = 0;
        for (int i = 0; i < text.Length - pattern.Length +1; i++)
        {
            if (text.Substring(i, pattern.Length).Equals(pattern, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}







//public static class TextTool
//{
//    public static int CountString(string text, string pattern)
//    {
//        int count = 0;
//        int i = 0;
//        while ((i = text.IndexOf(pattern, i)) != -1)
//        {
//            i += pattern.Length;
//            count++;
//        }
//        return count;
//    }
//}

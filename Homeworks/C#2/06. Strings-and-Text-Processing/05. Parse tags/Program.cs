//You are given a text. Write a program that changes the text in all 
//regions surrounded by the tags <upcase> and </upcase> to upper-case.

using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
        var openTag = "upcase";
        var closeTag = "/upcase";
        var text = Console.ReadLine().
            Split(new char[] { '<', '>' }).ToArray();

        var output = new StringBuilder();
        var toUpper = false;

        foreach (var word in text)
        {
            if(word == openTag)
            {
                toUpper = true;
                continue;
            }
            if (word == closeTag)
            {
                toUpper = false;
                continue;
            }
            if (toUpper)
            {
                output.Append(word.ToUpper());
            }
            else
            {
                output.Append(word);
            }
        }
        Console.WriteLine(output);
        }
    }

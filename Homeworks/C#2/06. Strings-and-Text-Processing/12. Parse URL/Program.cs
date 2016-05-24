//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the [protocol], 
//[server] and [resource] elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
    {
        static void Main()
        {
        string input = Console.ReadLine();
        Console.WriteLine(Parse(input));
        }
    static string Parse(string input)
    {
        Uri url = new Uri(input);

        string server = url.Host;
        string protocol = url.Scheme;
        string resource = url.LocalPath;

        StringBuilder result = new StringBuilder();
        result.Append("[protocol] = ")
            .Append(protocol + "\n")
            .Append("[server] = ")
            .Append(server + "\n")
            .Append("[resource] = ")
            .Append(resource + "\n");
        return result.ToString();
    }
    }

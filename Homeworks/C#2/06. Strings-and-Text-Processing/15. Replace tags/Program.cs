//Write a program that replaces in a HTML document given as string all the tags
//<a href="…">…</a> with corresponding tags[URL =…](…/URL).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReplaceTags6
{
    static void Main()
    {
        var stream = Console.OpenStandardInput(1048576);

        var BREAK = new[] { 13, 10, 3, 4, 12, 23, 25 };

        var isTag = false;

        var inputTag = new StringBuilder();

        var curBuffer = new byte[1024];

        var read = true;

        while (read)
        {
            var readChars = stream.Read(curBuffer, 0, 1024);

            for (int i = 0; i < readChars; i++)
            {
                var curChar = curBuffer[i];

                if (BREAK.Contains(curChar))
                {
                    read = false;
                    break;
                }
                
                if (curChar == '<' && isTag == false)
                {
                    isTag = true;
                }

                if (isTag)
                {
                    inputTag.Append((char)curChar);
                }
                
                if (curChar == '>' && isTag == true)
                {
                    if (isOpenAnchor(inputTag.ToString()))
                    {
                        isTag = true;
                    }
                    else
                    {
                        isTag = false;

                        if (ContainsCloseAnchor(inputTag.ToString()))
                        {
                            Console.Write(ReplaceTags(inputTag.ToString()));
                        }
                        else
                        {
                            Console.Write(inputTag);
                        }

                        inputTag.Clear();
                    }

                    continue;
                }

                if (!isTag)
                {
                    Console.Write((char)curChar);
                }
            }

            Console.WriteLine();
        }

        stream.Close();
    }

    static bool ContainsCloseAnchor(string Tag)
    {
        return Tag.Contains("</a>");
    }
    
    static bool isOpenAnchor(string Tag)
    {
        var openAnchor = "<a href=";

        for (int curLetter = 0; curLetter < openAnchor.Length; curLetter++)
        {
            if (Tag[curLetter] != openAnchor[curLetter])
            {
                return false;
            }
        }

        return !(ContainsCloseAnchor(Tag));
    }
    
    static string ReplaceTags(string toParse)
    {
        var toRemove = new Dictionary<string, string>
            {
                { "<a href=\"", ""  },
                { "\">"       , "~" },
                { "</a>"      , ""  }
            };

        foreach (var tag in toRemove)
        {
            toParse = toParse.Replace(tag.Key, tag.Value);
        }

        var strings = toParse.Split('~').ToArray();

        var format = "[{0}]({1})";
        return string.Format(format, strings[1], strings[0]);
    }
}
//Write a program that replaces in a HTML document given as string all the tags
//<a href="…">…</a> with corresponding tags[URL =…](…/URL).


using System;
using System.Text;

namespace ReplaceTags
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Trim();
            var output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<' && input[i + 1] == 'a')
                {
                    var anchor = ExtractAnchorOuterHtml(input, i);
                    var url = ExtractUrl(anchor);
                    var innerText = ExtractInnerText(anchor);
                    output.AppendFormat("[{0}]({1})", innerText, url);
                    i += anchor.Length - 1;
                    continue;
                }

                output.Append(input[i]);
            }

            Console.WriteLine(output);
        }

        static string ExtractInnerText(string anchor)
        {
            int indexOfFirstClosingBracket = anchor.IndexOf(">", 1);
            int indexOfSecondOpeningBracket = anchor.IndexOf("<", indexOfFirstClosingBracket);
            var innerText = anchor.Substring(indexOfFirstClosingBracket + 1, indexOfSecondOpeningBracket - indexOfFirstClosingBracket - 1);
            return innerText;
        }

        static string ExtractUrl(string anchor)
        {
            int firstIndexOfDoubleQuote = anchor.IndexOf("\"");
            int lastIndexOfDoubleQuote = anchor.LastIndexOf("\"");
            var url = anchor.Substring(firstIndexOfDoubleQuote + 1, lastIndexOfDoubleQuote - firstIndexOfDoubleQuote - 1);
            return url;
        }

        static string ExtractAnchorOuterHtml(string text, int i)
        {
            int indexOfClosingAnchorTag = text.IndexOf("</a>", i);
            var anchor = text.Substring(i, indexOfClosingAnchorTag + 4 - i);
            return anchor;
        }
    }
}
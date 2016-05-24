//Write a program that extracts from a given text all sentences containing 
//given word

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
        string word = Console.ReadLine().ToLower();
        string text = Console.ReadLine();
        string[] sentences = text.Split('.').ToArray();

        char[] separators = ExtractSeparators(text);
        StringBuilder filterSentences = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
            var words = sentences[i].ToLower().Split(separators).ToArray();
            bool haveMatch = words.Any(x => x == word);

            if (haveMatch)
            {
                filterSentences.Append(sentences[i] + ".");
            }
        }
        Console.WriteLine(string.Join(" ", filterSentences));
        }
    static char[] ExtractSeparators(string text)
    {
        char[] separators = text.Where(x => !char.IsLetter(x) && x != '.')
            .Distinct().ToArray();
        return separators;
    }
    }

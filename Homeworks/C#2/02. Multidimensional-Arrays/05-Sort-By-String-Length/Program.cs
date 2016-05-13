//You are given an array of strings.Write a method that sorts the array by the length of its elements
//(the number of characters composing them).

using System;
using System.Collections;

    class SortByStringLength
    {
        public class myCompare : IComparer
        {
            int IComparer.Compare(object Right, object Left)
            {
                string strLeft = Left.ToString();
                string strRight = Right.ToString();

                if (strRight.Length < strLeft.Length)
                {
                    return -1;
                }
                else if (strRight.Length > strLeft.Length)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
        
            string[] toSearch = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                toSearch[i] = Console.ReadLine();
            }
            
            myCompare sortStrLength = new myCompare();
        
            Array.Sort(toSearch, sortStrLength);
        
            Console.WriteLine(string.Join(Environment.NewLine, toSearch));
        }
    }
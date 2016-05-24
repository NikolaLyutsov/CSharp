//Write a program to check if in a given expression the(and ) brackets are put correctly.

using System;

class Brackets
{
    static void Main()
    {
        string expr = Console.ReadLine();
        CheckIsTheExpresionIsCorrect(expr);

    }
    static void CheckIsTheExpresionIsCorrect(string expr)
    {
        char[] exprCharArr = expr.ToCharArray();
        int bracket = 0;
        
        for (int i = 0; i < exprCharArr.Length; i++)
        {

            if (exprCharArr[i] == '(')
            {
                bracket++;
            }
            else if (exprCharArr[i] == ')')
            {
                bracket--;
            }
            if (bracket < 0)
            {
                break;
            }
        }
        if (bracket == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}
//We are given a matrix of strings of size N x M.Sequences in the matrix we define as sets of several neighbour elements located on the 
//same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

using System;

namespace _03_Sequence_In_Matrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            string sizeInput = Console.ReadLine();

            string[] Sizes = sizeInput.Trim(' ').Split(' ');

            int inputRows = int.Parse(Sizes[0]);
            int inputCols = int.Parse(Sizes[1]);
            
            string[][] toSearch = new string[inputRows][];

            for (int i = 0; i < inputRows; i++)
            {
                toSearch[i] = Console.ReadLine().Trim(' ').Split(' ');
            }
            
            int MaxSequence = 0;
            int CurSequence = 1;
            
            for (int row = 0; row < inputRows; row++)
            {
                CurSequence = 1;

                for (int col = 1; col < inputCols; col++)
                {
                    if (toSearch[row][col] ==
                        toSearch[row][col - 1])
                    {
                        CurSequence++;
                    }
                    else
                    {
                        if (CurSequence > MaxSequence)
                        {
                            MaxSequence = CurSequence;
                        }
                        CurSequence = 1;
                    }
                }
                
                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            for (int col = 0; col < inputCols; col++)
            {
                CurSequence = 1;

                for (int row = 1; row < inputRows; row++)
                {
                    if (toSearch[row][col] ==
                        toSearch[row - 1][col])
                    {
                        CurSequence++;
                    }
                    else
                    {
                        if (CurSequence > MaxSequence)
                        {
                            MaxSequence = CurSequence;
                        }
                        CurSequence = 1;
                    }
                }
                
                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }

            for (int Col = 1; Col < inputCols; Col++)
            {
                CurSequence = 1;

                for (int curMod = 1;
                         curMod <= Math.Min(Col, inputRows - 1);
                         curMod++)
                {
                    if (toSearch[0 + curMod][Col - curMod] ==
                        toSearch[0 + (curMod - 1)][Col - (curMod - 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }

            for (int Row = 1; Row < inputRows; Row++)
            {
                CurSequence = 1;

                for (int curMod = 1;
                         curMod <= Math.Min(inputRows - 1 - Row - 1, inputCols - 2);
                         curMod++)
                {
                    if (toSearch[Row + curMod][(inputCols - 1) - curMod] ==
                        toSearch[Row + (curMod + 1)][(inputCols - 1) - (curMod + 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            for (int Row = inputRows - 2;
                     Row >= 0;
                     Row--)
            {
                CurSequence = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(inputRows - Row - 1, inputCols - 1);
                    curMod++)
                {
                    if (toSearch[Row + curMod][0 + curMod] ==
                        toSearch[Row + (curMod - 1)][0 + (curMod - 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            for (int Row = 1;
                     Row < inputRows - 1;
                     Row++)
            {
                CurSequence = 1;

                for (int curMod = 1;
                    curMod <= Math.Min(Row - 1, inputCols - 1);
                    curMod++)
                {
                    if (toSearch[Row - curMod][(inputCols - 1) - curMod] ==
                        toSearch[Row - (curMod - 1)][(inputCols - 1) - (curMod - 1)])
                    {
                        CurSequence++;
                    }
                }

                if (CurSequence > MaxSequence)
                {
                    MaxSequence = CurSequence;
                }
            }
            
            Console.WriteLine(MaxSequence);
        }
    }
}
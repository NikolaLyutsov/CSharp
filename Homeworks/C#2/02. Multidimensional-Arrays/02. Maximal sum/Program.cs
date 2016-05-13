//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
//Print that sum.

using System;

namespace _02_Maximal_Sum_2_Line_By_Line
{
    class Program
    {
        static void Main()
        {
            string[] Sizes = Console.ReadLine().Trim(' ').Split(' ');
            
            byte areaSize = 3;

            short MaxSum;
            short curSum;

            short[][] curSums = new short[areaSize][];
            
            for (int curRow = 0;curRow < areaSize;curRow++)
            {
                curSums[curRow] = ReadInputLine(areaSize);
            }
            
            MaxSum = FindMaxSum(curSums);
            
            if (int.Parse(Sizes[0]) == 3)
            {
                Console.WriteLine(MaxSum);
                return;
            }

            int RowToWrite = 0;

            for (int Row = 3;
                     Row < int.Parse(Sizes[0]);
                     Row++)
            {
                curSums[RowToWrite % areaSize] =
                            ReadInputLine(areaSize);
                
                MaxSum = (curSum = FindMaxSum(curSums)) > MaxSum ?
                          curSum : MaxSum;
                
            }
            
            Console.WriteLine(MaxSum);
        }
        
        public static short[] ReadInputLine(short areaSize)
        {
            string[] Input = Console.ReadLine().Trim(' ').Split(' ');

            short[] ArrayOfSums = new short[Input.Length - (areaSize - 1)];

            ArrayOfSums[0] = (short)(short.Parse(Input[0]) +   
                                     short.Parse(Input[1]) +   
                                     short.Parse(Input[2]));   

            for (int curElement = 1;curElement < Input.Length - (areaSize - 1);curElement++)
            {
                ArrayOfSums[curElement] =                                  
                        ArrayOfSums[curElement - 1];                      
                                                                        
                ArrayOfSums[curElement] -=                                
                        short.Parse(Input[curElement - 1]);                
                                                                           
                ArrayOfSums[curElement] +=                               
                        short.Parse(Input[curElement + (areaSize - 1)]);   

            }

            return ArrayOfSums;
        }

        public static short FindMaxSum(short[][] curRows)
        {
            short MaxSum = short.MinValue;
            short curSum = 0;

            for (int curElement = 0;
                     curElement < curRows[0].Length;
                     curElement++)
            {
                curSum = 0;

                for (int Row = 0;
                         Row < curRows.Length;
                         Row++)
                {
                    curSum += curRows[Row][curElement];
                }

                MaxSum = curSum > MaxSum ?
                         curSum : MaxSum;
            }
            return MaxSum;
        }
    }
}
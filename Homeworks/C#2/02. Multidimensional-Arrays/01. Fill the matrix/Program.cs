//Write a program that fills and prints a matrix of size (n, n) as shown below.

using System;

namespace _01_Fill_The_Matrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            char arrayType = Console.ReadLine().ToLower()[0];
            short[,] toFill = new short[arraySize, arraySize];

            if (arrayType == 'a')
            {
                toFill = OutputTypeA(toFill);
                PrintTheMatrix(toFill);
            }

            if (arrayType == 'b')
            {
                toFill = OutputTypeB(toFill);
                PrintTheMatrix(toFill);
            }
            
            if (arrayType == 'c')
            {
                toFill = OutputTypeC(toFill);
                PrintTheMatrix(toFill);
            }

            if (arrayType == 'd')
            {
                toFill = OutputTypeD(toFill);
                PrintTheMatrix(toFill);
            }

        }
        
        public static short[,] OutputTypeA(short[,] toFill)
        {
            short toPrint = 1;
            
            for (int col = 0; col < toFill.GetLength(0); col++)
            {
                for (int row = 0; row < toFill.GetLength(1); row++)
                {
                    toFill[col, row] = toPrint;
                    toPrint++;
                }
            }

            return toFill;
        }

        public static short[,] OutputTypeB(short[,] toFill)
        {
            short toPrint = 1;
            for (int col = 0; col < toFill.GetLength(0); col++)
            {
                if ((col & 1) == 0)
                {
                    for (int row = 0; row < toFill.GetLength(1); row++)
                    {
                        toFill[col, row] = toPrint;
                        toPrint++;
                    }
                }
                else
                {
                    for (int row = toFill.GetLength(1) - 1; row >= 0; row--)
                    {
                        toFill[col, row] = toPrint;
                        toPrint++;
                    }
                }

            }
            return toFill;
        }
        
        public static short[,] OutputTypeC(short[,] toFill)
        {
            short toPrint = 1;

            int Target = toFill.GetLength(1) - 1;
            
            while (Target >= 0)
            {
                for (int row = 0; row < toFill.GetLength(1); row++)
                {
                    for (int col = 0; col < toFill.GetLength(0) - Target; col++)
                    {
                        if (row - col == Target)
                        {
                            toFill[col, row] = toPrint;
                            toPrint++;
                        }
                    }
                }

                Target--;
            }
            
            while (Target >= -(toFill.GetLength(1) - 1))
            {
                for (int row = 0;
                         row < toFill.GetLength(1);
                         row++)
                {
                    for (int col = 0 - Target;
                             col < toFill.GetLength(0);
                             col++)
                    {
                        if (row - col == Target)
                        {
                            toFill[col, row] = toPrint;
                            toPrint++;
                        }
                    }
                }

                Target--;
            }

            return toFill;
        }
        
        public static short[,] OutputTypeD(short[,] toFill)
        {
            short toPrint = 1;
            
            int curCol = 0;
            int curRow = 0;
            
            int colSpeed = 0;
            int rowSpeed = 1;

            bool canMove = true;
            int curDirection = 0; 
            
            toFill[0, 0] = 1;
            toPrint++;

            while (true)
            {
                if (!((curCol + colSpeed) < 0) &&
                    !((curCol + colSpeed) >= toFill.GetLength(0)) &&
                    !((curRow + rowSpeed) >= toFill.GetLength(1)) &&
                    !((curRow + rowSpeed) < 0))
                {
                    if (!(toFill[curCol, curRow + rowSpeed] > 0) ||
                        !(toFill[curCol + colSpeed, curRow] > 0))
                    {
                        curCol += colSpeed;
                        curRow += rowSpeed;

                        toFill[curCol, curRow] = toPrint;
                        toPrint++;
                    }
                    else
                    {
                        canMove = false;
                    }
                }
                else
                {
                    canMove = false;
                }

                if (!canMove)
                {
                    if (curDirection == 0)
                    {
                        curDirection = 1;
                        colSpeed = 1;
                        rowSpeed = 0;
                        canMove = true;
                    }

                    else if (curDirection == 1)
                    {
                        curDirection = 2;
                        colSpeed = 0;
                        rowSpeed = -1;
                        canMove = true;
                    }

                    else if (curDirection == 2)
                    {
                        curDirection = 3;
                        colSpeed = -1;
                        rowSpeed = 0;
                        canMove = true;
                    }

                    else if (curDirection == 3)
                    {
                        curDirection = 0;
                        colSpeed = 0;
                        rowSpeed = 1;
                        canMove = true;
                    }
                }

                if (toPrint - 1 == toFill.GetLength(0) * toFill.GetLength(1))
                {
                    break;
                }
            }

            return toFill;
        }
        
        public static void PrintTheMatrix(short[,] toPrint)
        {
            for (int row = 0; row < toPrint.GetLength(1); row++)
            {
                for (int col = 0; col < toPrint.GetLength(0); col++)
                {
                    Console.Write(toPrint[col, row]);

                    if (col != toPrint.GetLength(0) - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();                                   
            }

            return;
        }
    }
}
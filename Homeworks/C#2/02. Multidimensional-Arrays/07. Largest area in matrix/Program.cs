//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    using System.Runtime.CompilerServices;

    public class LargestAreaInMatrix
    {
        private static bool[,] visited;
        private static int[,] matrix;
        private static int rows, cols;
        private static int counter = 0;
        private static int maxCounter = 0;

        private static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            rows = dimentions[0];
            cols = dimentions[1];
            matrix = new int[rows, cols];
            visited = new bool[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (!visited[r, c])
                    {
                        DFS(r, c, matrix[r, c]);

                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }

                        counter = 0;
                    }
                }
            }

            Console.WriteLine(maxCounter);
        }

        private static void DFS(int row, int col, int element)
        {
            if (matrix[row, col] == element)
            {
                counter++;
                visited[row, col] = true;

                if (IsValidCell(row, col - 1))
                {
                    DFS(row, col - 1, element);
                }

                if (IsValidCell(row - 1, col))
                {
                    DFS(row - 1, col, element);
                }

                if (IsValidCell(row, col + 1))
                {
                    DFS(row, col + 1, element);
                }

                if (IsValidCell(row + 1, col))
                {
                    DFS(row + 1, col, element);
                }
            }
        }

        private static bool IsValidCell(int row, int col)
        {
            if (row < 0 || col < 0 || row >= rows || col >= cols || visited[row, col])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
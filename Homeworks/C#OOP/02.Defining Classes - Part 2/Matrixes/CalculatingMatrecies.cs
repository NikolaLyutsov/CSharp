using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Matrixes.Models;

namespace Matrixes
{
    class CalculatingMatrecies
    {
        static void Main()
        {
            int row = 3, col = 3;
            var matrix1 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = r + c + 2;
                }
            }
            row = 3;
            col = 3;
            var matrix2 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (r == c)
                    {

                        matrix2[r, c] = 1;
                    }
                }
            }
            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);
            Console.WriteLine(matrix1 * matrix2);
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine(matrix1 - matrix2);
            if (matrix1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Type type = typeof(Matrix<int>);
            object[] attr = type.GetCustomAttributes(false);
            foreach (var item in attr)
            {
                Console.WriteLine(item);
            }
        }
    }
}

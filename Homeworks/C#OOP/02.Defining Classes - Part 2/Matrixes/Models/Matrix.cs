using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes.Models
{
    [Version(1, 10)]
    class Matrix<T> 
    {
        private T[,] matrix;
        private long v1;
        private long v2;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public Matrix(long v1, long v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(0) ||
                m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrixes should have equal dimentions");
            }

            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
            for (int r = 0; r < result.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    result[r, c] = (dynamic)m1[r, c] + (dynamic)m2[r, c];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {

            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(0) ||
                m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrixes shou8ld have equal dimentions");
            }

            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
            for (int r = 0; r < result.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    T max = m1[r, c];
                    T min = m2[r, c];
                    if ((dynamic)m1[r, c] < (dynamic)m2[r, c])
                    {
                        min = m1[r, c];
                        max = m2[r, c];

                    }
                    result[r, c] = (dynamic)max - (dynamic)min;
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(1) != m2.matrix.GetLength(0))
            {
                throw new ArgumentException("Matrixes should have equal dimentions");
            }

            var result = new Matrix<T>(m1.matrix.GetLength(0), m2.matrix.GetLength(1));
            for (int r = 0; r < m1.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < result.matrix.GetLength(1); c++)
                {
                    for (int i = 0; i < m1.matrix.GetLength(1); i++)
                    {
                        result[r, c] += (dynamic)m1[r, i] * (dynamic)m2[i, c];
                    }
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;
            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = false;
            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }
            return !isTrue;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    sb.AppendFormat("{0, 3} ", this.matrix[row, col]);
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}

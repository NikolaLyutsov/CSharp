//Write a class Matrix, to hold a matrix of integers.Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixClassTest;

namespace MatrixClassTest
{
    class MatrixClassTesting
    {
        static void Main(string[] args)
        {

            Matrix newMatrix = new Matrix(16);
            newMatrix.FillWithSequence(1);

            Matrix matrixTwo = new Matrix(8);
            matrixTwo.FillWithSequence(3);

            Matrix matrixThree = newMatrix + matrixTwo;
        }
    }
}
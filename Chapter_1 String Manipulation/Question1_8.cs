using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CrackingTheCodingInterview_1_Arrays_and_Strings_Tests
{
    public class Question1_8
    {

        public int[,]  ZeroMatrix(int[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
                {
                    if(matrix[i,k] == 0)
                    {
                        makeZeros(matrix, i, k);
                    }
                }
            }
            return matrix;
        }




        public int[,] makeZeros(int[,] matrix, int row, int col)
        {
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row, i] = 0;
            }
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                matrix[k, col] = 0;
            }
            return matrix;
        }
    }
}

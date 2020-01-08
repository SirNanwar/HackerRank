using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Arrays
{
    public class _2DArraysDS
    {
        // Complete the hourglassSum function below.
        public static int hourglassSum(int[][] arr)
        {
            int hourglassSum = int.MinValue;

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    hourglassSum = Math.Max(hourglassSum, 
                                            ComputeHourglass(arr, i, j));
                }
            }

            return hourglassSum;
        }

        private static int ComputeHourglass(int[][] matrix,
                                            int row,
                                            int column)
        {
            int result = 0;

            result += matrix[row][column] + matrix[row][column + 1] + matrix[row][column + 2];
            result += matrix[row + 1][column + 1];
            result += matrix[row + 2][column] + matrix[row + 2][column + 1] + matrix[row + 2][column + 2];

            return result;
        }
    }
}

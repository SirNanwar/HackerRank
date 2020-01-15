using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Arrays
{
    public class ArrayManipulation
    {
        //TODOFD - Fix
        //Se isto nã o funcionar vai ser porque a ordem inversa tem de ser tratada com se fosse do inicio para o fim

        public static int arrayManipulation(int size,
                                            int operations,
                                            int[][] matrix)
        {
            int[] arr = new int[size];

            for(int i = 0; i < operations; i++) 
            {
                int start = matrix[i][0] - 1;
                int end = matrix[i][1] - 1;
                int value = matrix[i][2];

                while(start <= end) 
                {
                    arr[start] += value;
                    start++;
                }
            }

            int result = -1;

            foreach (int val in arr) 
            {
                result = Math.Max(result, val);
            }

            return result;
        }
    }
}

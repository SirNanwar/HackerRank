using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Arrays
{
    public class ArrayManipulation
    {
        public static long arrayManipulation(int n,
                                             int[][] queries)
        {
            long[] arr = new long[n + 1];

            int a, b, k;

            foreach(int[] query in queries) 
            {
                a = query[0] - 1;
                b = query[1];
                k = query[2];

                arr[a] += k;
                arr[b] -= k;
            }

            long result = -1;
            long epsilon = 0;
            foreach(long val in arr) 
            {
                epsilon += val;
                result = Math.Max(epsilon, result);
            }

            return result;
        }
    }
}

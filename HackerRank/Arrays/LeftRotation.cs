using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Arrays
{
    public class LeftRotation
    {
        // Complete the rotLeft function below.
        public static int[] rotLeft(int[] a, int d)
        {
            int[] result = new int[a.Length];
            int rotations = ComputeRotations(a.Length, d);

            for (int i = 0; i < a.Length; i++)
            {
                if(i + rotations < a.Length)
                {
                    result[i] = a[i + rotations];
                }
                else
                {
                    result[i] = a[i - (a.Length - rotations)];
                }
            }

            return result;
        }

        private static int ComputeRotations(int a, int d)
        {
            int remainder = d / a;

            return d - (a * remainder);
        }
    }
}

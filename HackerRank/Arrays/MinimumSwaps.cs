using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Arrays
{
    public class MinimumSwaps
    { 
        public static int minSwaps(int[] arr)
        {
            int swaps = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        if (arr[j] == i + 1)
                        {
                            int dummy = arr[i];
                            arr[i] = arr[j];
                            arr[j] = dummy;

                            break;
                        }
                    }

                    swaps++;
                }
            }

            return swaps;
        }
    }
}

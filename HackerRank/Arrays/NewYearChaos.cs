using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int bribes = 0;

            int expectedFirst = 1;
            int expectedSecond = 2;
            int expectedThird = 3;

            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] == expectedFirst)
                {
                    expectedFirst = expectedSecond;
                    expectedSecond = expectedThird;
                }
                else if (q[i] == expectedSecond)
                {
                    bribes++;
                    expectedSecond = expectedThird;
                }
                else if (q[i] == expectedThird)
                {
                    bribes += 2;
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                expectedThird++;
            }

            Console.WriteLine(bribes);
        }
    }
}

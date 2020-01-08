using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Warm_up_Challenges
{
    public class JumpingOnTheClouds
    {
        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;

            int lastCloud = c.Length - 1; 

            for(int i = 0; i < lastCloud; i++)
            {
                if (i != lastCloud - 1 &&
                    c[i + 2] == 0)
                {
                    i++;
                }
                jumps++;
            }
            return jumps;
        }
    }
}

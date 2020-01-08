using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.Warm_up_Challenges
{
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            long b = n / s.Length;
            long count = CountInString(s, 'a') * b;

            int remainder = Convert.ToInt32( n - (s.Length * b));

            s = s.Remove(remainder);
            count += CountInString(s, 'a');

            return count;
        }

        private static int CountInString(string s, char c)
        {
            int count = 0;

            foreach (char x in s)
            {
                if (x == c)
                    count++;
            }
            return count;
        }
    }
}

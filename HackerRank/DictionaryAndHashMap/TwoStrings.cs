using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DictionaryAndHashMap
{
    public class TwoStrings
    {
        public static string twoStrings(string s1, string s2)
        {
            List<char> chars = new List<char>(0);

            foreach(char sub1 in s1)
            {
                if (chars.Contains(sub1))
                    continue;
                chars.Add(sub1);

                if(s2.IndexOf(sub1) >= 0)
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
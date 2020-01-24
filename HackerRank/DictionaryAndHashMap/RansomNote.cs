using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DictionaryAndHashMap
{
    public class RansomNote
    {
        public static string checkMagazine(string[] magazine,
                                           string[] note)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < magazine.Length; i++) 
            {
                if (dic.ContainsKey(magazine[i])) 
                {
                    dic[magazine[i]]++;
                }
                else 
                {
                    dic.Add(magazine[i], 1);
                }

                if(i >= note.Length) 
                {
                    continue;
                }

                if (dic.ContainsKey(note[i])) 
                {
                    dic[note[i]]--;
                }
                else 
                {
                    dic.Add(note[i], -1);
                }
            }

            foreach(int val in dic.Values) 
            {
                if (val < 0)
                    return "No";
            }
            return "Yes";
        }
    }
}

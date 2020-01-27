using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DictionaryAndHashMap
{
    public class FrequencyQueries
    {
        public static List<int> freqQuery(List<List<int>> queries)
        {
            var result = new List<int>();

            Dictionary<int, int> dic1 = new Dictionary<int, int>();

            Dictionary<int, int> dic2 = new Dictionary<int, int>();
            dic2[0] = 0;

            foreach (List<int> query in queries)
            {
                switch (query[0])
                {
                    case 1:
                        if (!dic1.ContainsKey(query[1]))
                        {
                            dic1[query[1]] = 0;
                            dic2[0]++;
                        }

                        dic2[dic1[query[1]]]--;
                        dic1[query[1]]++;

                        if (!dic2.ContainsKey(dic1[query[1]]))
                        {
                            dic2[dic1[query[1]]] = 0;
                        }

                        dic2[dic1[query[1]]]++;

                        break;
                    case 2:
                        if (dic1.ContainsKey(query[1]))
                        {
                            if (dic1[query[1]] > 0)
                            {
                                dic1[query[1]]--;
                                dic2[dic1[query[1]] + 1]--;

                                if (dic1[query[1]] >= 0)
                                {
                                    if (!dic2.ContainsKey(dic1[query[1]]))
                                    {
                                        dic2[dic1[query[1]]] = 0;
                                    }

                                    dic2[dic1[query[1]]]++;
                                }
                            }
                        }
                        break;
                    case 3:
                        result.Add((dic2.ContainsKey(query[1]) &&
                                    dic2[query[1]] > 0) ? 1 : 0);
                        break;
                }
            }

            return result;
        }
    }
}

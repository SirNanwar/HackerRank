using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DictionaryAndHashMap
{
    public class CountTriplets
    {
        public static long countTriplets(long[] arr, long r) 
        {
            Dictionary<long, long> counts = new Dictionary<long, long>();
            Dictionary<long, long> pairs = new Dictionary<long, long>();

            long result = 0;

            for(long i = arr.LongLength - 1; i > -1; i--) 
            {
                long first = arr[i];
                long second = first * r;

                if (pairs.ContainsKey(second)) 
                {
                    result += pairs[second];
                }

                if (counts.ContainsKey(second)) 
                {
                    if (pairs.ContainsKey(first))
                        pairs[first] += counts[second];
                    else
                        pairs[first] = counts[second];
                }

                if (counts.ContainsKey(first))
                    counts[first]++;
                else
                    counts[first] = 1;
            }

            return result;
        }
    }
}

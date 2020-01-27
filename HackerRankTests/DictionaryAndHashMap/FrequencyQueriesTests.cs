using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.DictionaryAndHashMap;
using System.Collections.Generic;

namespace HackerRankTests.DictionaryAndHashMap
{
    [TestClass]
    public class FrequencyQueriesTests
    {
        [TestMethod]
        public void FrequencyQueriesTest1()
        {
            List<int> result = new List<int>();

            List<List<int>> queries = new List<List<int>>
            {
                new List<int>{1,5},
                new List<int>{1,6},
                new List<int>{3,2},
                new List<int>{1,10},
                new List<int>{1,10},
                new List<int>{1,6},
                new List<int>{2,5},
                new List<int>{3,2}
            };

            result = FrequencyQueries.freqQuery(queries);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void FrequencyQueriesTest2()
        {
            List<int> result = new List<int>();

            List<List<int>> queries = new List<List<int>>
            {
                new List<int>{3,4},
                new List<int>{2,1003},
                new List<int>{1,16},
                new List<int>{3,1}
            };

            result = FrequencyQueries.freqQuery(queries);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void FrequencyQueriesTest3()
        {
            List<int> result = new List<int>();

            List<List<int>> queries = new List<List<int>>
            {
                new List<int>{1,3},
                new List<int>{2,3},
                new List<int>{3,2},
                new List<int>{1,4},
                new List<int>{1,5},
                new List<int>{1,5},
                new List<int>{1,4},
                new List<int>{3,2},
                new List<int>{2,4},
                new List<int>{3,2}
            };

            result = FrequencyQueries.freqQuery(queries);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(1, result[2]);
        }
    }
}

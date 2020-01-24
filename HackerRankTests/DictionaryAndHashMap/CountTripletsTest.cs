using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.DictionaryAndHashMap;

namespace HackerRankTests.DictionaryAndHashMap
{
    [TestClass]
    public class CountTripletsTest
    {
        [TestMethod]
        public void CountTripletsTest1() 
        {
            long[] arr = { 1, 2, 2, 4 };
            long r = 2;

            long result = CountTriplets.countTriplets(arr, r);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CountTripletsTest2()
        {
            long[] arr = { 1, 3, 9, 9, 27, 81 };
            long r = 3;

            long result = CountTriplets.countTriplets(arr, r);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CountTripletsTest3()
        {
            long[] arr = { 1, 5, 5, 25, 125 };
            long r = 5;

            long result = CountTriplets.countTriplets(arr, r);

            Assert.AreEqual(4, result);
        }
    }
}

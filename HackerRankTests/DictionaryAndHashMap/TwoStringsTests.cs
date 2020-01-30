using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.DictionaryAndHashMap;

namespace HackerRankTests.DictionaryAndHashMap
{
    [TestClass]
    public class TwoStringsTests
    {
        private const string YES = "YES";
        private const string NO = "NO";

        [TestMethod]
        public void TwoStringsTest1()
        {
            string result = TwoStrings.twoStrings("hello", "world");

            Assert.AreEqual(YES, result);
        }

        [TestMethod]
        public void TwoStringsTest2()
        {
            string result = TwoStrings.twoStrings("hi", "world");

            Assert.AreEqual(NO, result);
        }

        [TestMethod]
        public void TwoStringsTest3()
        {
            string result = TwoStrings.twoStrings("", "world");

            Assert.AreEqual(NO, result);
        }

        [TestMethod]
        public void TwoStringsTest4()
        {
            string result = TwoStrings.twoStrings("aaa", "aaaaaaaa");

            Assert.AreEqual(YES, result);
        }

        [TestMethod]
        public void TwoStringsTest5()
        {
            string result = TwoStrings.twoStrings("iebvnpiuebvnioejncpubyo39pfq0843pubgnoipvf0837c9g86tfi3fy8u9j0", "bvnerumiw«v'9087g0hu543g0'87h038ho4uf+0'8hc4738o7fg9py438ofuhyo379fh3o87g");

            Assert.AreEqual(YES, result);
        }

        [TestMethod]
        public void TwoStringsTest6()
        {
            string result = TwoStrings.twoStrings("bbbbbbbbbbbbbxcdtvfygbuhnbvgcfytdxcfvygubhniibguvcfdtxtcfyvgbuhnijhbvcytxtcdfyvgbuhnihvycdtxdctfvygbuhnibuvctxeyvbuinbyuvtctxrctvfygbuniyuvtctxddcfyvbuniybuyrcdtfvygvctextfvygubhbgvfcdtxcfyvgubvyctxfvygbuhnia", "a");

            Assert.AreEqual(YES, result);
        }
    }
}
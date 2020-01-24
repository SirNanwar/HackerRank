using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.DictionaryAndHashMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTests.DictionaryAndHashMap
{
    [TestClass]
    public class RansomNoteTests
    {
        [TestMethod]
        public void RansomNoteTest1() 
        {
            string[] magazine = { "give",
                                  "me",
                                  "one",
                                  "grand",
                                  "today",
                                  "night"};

            string[] note = { "give", 
                              "one", 
                              "grand", 
                              "today" };

            string result = RansomNote.checkMagazine(magazine, note);

            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void RansomNoteTest2()
        {
            string[] magazine = { "two",
                                  "times",
                                  "three",
                                  "is",
                                  "not",
                                  "four"};

            string[] note = { "two",
                              "times",
                              "two",
                              "is",
                              "four"};

            string result = RansomNote.checkMagazine(magazine, note);

            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void RansomNoteTest3()
        {
            string[] magazine = { "ive",
                                  "got",
                                  "a",
                                  "lovely",
                                  "bunch",
                                  "of",
                                  "coconuts"};

            string[] note = { "ive",
                              "got",
                              "some",
                              "coconuts"};

            string result = RansomNote.checkMagazine(magazine, note);

            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void RansomNoteTest4()
        {
            string[] magazine = { "give",
                                  "me",
                                  "one",
                                  "grand",
                                  "today",
                                  "night"};

            string[] note = { "Give",
                              "one",
                              "grand",
                              "today" };

            string result = RansomNote.checkMagazine(magazine, note);

            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void RansomNoteTest5()
        {
            string[] magazine = { "there", "was", "a", "bird", "in", "my", "bedroom",
                                  "and", "I", "must", "tell", "you", "without",
                                  "a", "word", "of", "doubt", "that", "the",
                                  "bird", "is", "the", "biggest", "bird", "I", "have",
                                  "ever", "seen"};

            string[] note = { "the",
                              "bird",
                              "is",
                              "the",
                              "word"};

                string result = RansomNote.checkMagazine(magazine, note);

            Assert.AreEqual("Yes", result);
        }
    }
}

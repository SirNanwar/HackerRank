using HackerRank.DictionaryAndHashMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises.DictionaryAndHashMaps
{
    public class TwoStringsApp : IGenericDictionaryExercise
    {
        private int p;

        public void Run()
        {
            PrintProblem();

            List<string> results = new List<string>(0);

            Console.WriteLine("number of test cases:");
            p = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < p; i++)
            {
                results.Add(TwoStrings.twoStrings(Console.ReadLine(),
                                                  Console.ReadLine()));
            }

            Console.WriteLine();
            Console.WriteLine("Result:");
            foreach(string result in results)
                Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("Given two strings, determine if they " +
                "share a common substring. A substring may be as small " +
                "as one character. " + Environment.NewLine +
                "For example, the words " +
                "\"a\", \"and\", \"art\" " +
                "share the common substring . The words " +
                "\"be\" and \"cat\" do not share a substring. ");
            Program.AddSeparator();
        }
    }
}
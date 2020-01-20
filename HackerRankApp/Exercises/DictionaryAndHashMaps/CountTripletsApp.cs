using HackerRank.DictionaryAndHashMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises.DictionaryAndHashMaps
{
    class CountTripletsApp : IGenericDictionaryExercise
    {
        private long[] a;
        private long[] d;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("size of array: common ratio:");
            a = System.Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt64(aTemp));
            Console.WriteLine("array:");
            d = System.Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt64(aTemp));

            long result = CountTriplets.countTriplets(d, a[1]);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("You are given an array and you need" +
                " to find number of tripets of indices (i,j,k)" +
                " such that the elements at those indices are in" +
                " geometric progression for a given " +
                "common ratio r and i." +
                "i < j < k");
            Program.AddSeparator();
        }
    }
}

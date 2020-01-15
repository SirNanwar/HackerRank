using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.Arrays;

namespace HackerRankApp.Exercises.Array
{
    class MinimumSwapsApp : IGenericArrayExercise
    {
        private int[] a;
        private int d;

        public void Run()
        {
            PrintProblem();

            int result;

            Console.WriteLine("Number of elements:");
            d = Convert.ToInt32(Console.ReadLine());
            if (d == 0)
            {
                result = 0;

            }
            else
            {
                Console.WriteLine("array:");
                a = System.Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

                result = MinimumSwaps.minSwaps(a);
            }
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("You are given an unordered array consisting of consecutive integers" +
                "  [1, 2, 3, ..., n] without any duplicates. " +
                "You are allowed to swap any two elements. " +
                "You need to find the minimum number of swaps required to sort the array " +
                "in ascending order.");
            Program.AddSeparator();
        }
    }
}
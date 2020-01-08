using HackerRank.Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises.Array
{
    class _2DArraysDSApp : IGenericArrayExercise
    {
        private int[][] arr;

        public void Run()
        {
            PrintProblem();

            arr = new int[6][];
            Console.WriteLine("arr:");
            for (int i = 0; i < 6; i++)
            {
                arr[i] = System.Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = _2DArraysDS.hourglassSum(arr);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("TODO");
            Program.AddSeparator();
        }
    }
}

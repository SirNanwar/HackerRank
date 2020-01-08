using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.Arrays;

namespace HackerRankApp.Exercises.Array
{
    class LeftRotationApp : IGenericArrayExercise
    {
        private int[] a;
        private int d;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("a:");
            a = System.Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            Console.WriteLine("d:");
            d = Convert.ToInt32(Console.ReadLine());

            int[] result = LeftRotation.rotLeft(a, d);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(string.Join(" ", result));
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

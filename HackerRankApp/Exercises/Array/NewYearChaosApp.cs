using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.Arrays;

namespace HackerRankApp.Exercises.Array
{
    class NewYearChaosApp : IGenericArrayExercise
    {
        public void Run()
        {
            PrintProblem();

            Console.WriteLine("t:");
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                Console.WriteLine("n:");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("q:");
                int[] q = System.Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                NewYearChaos.minimumBribes(q);
                Console.ReadKey();
            }
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("TODO");
            Program.AddSeparator();
        }
    }
}

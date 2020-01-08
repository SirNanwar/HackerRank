using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.Warm_up_Challenges;

namespace HackerRankApp.Exercises
{
    class JumpingOnTheCloudsApp : IGenericWarmUpExercise
    {
        private int[] c;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("c:");
            c = System.Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = JumpingOnTheClouds.jumpingOnClouds(c);

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

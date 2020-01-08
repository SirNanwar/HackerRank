using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.Warm_up_Challenges;

namespace HackerRankApp.Exercises
{
    class CountingValleysApp : IGenericWarmUpExercise
    {
        private int n;
        private string s;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("s:");
            s = Console.ReadLine();

            int result = CountingValleys.countingValleys(n, s);

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

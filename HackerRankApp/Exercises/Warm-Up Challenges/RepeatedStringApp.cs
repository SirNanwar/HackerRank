using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.Warm_up_Challenges;

namespace HackerRankApp.Exercises
{
    class RepeatedStringApp : IGenericWarmUpExercise
    {
        private string s;
        private long n;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("s:");
            s = Console.ReadLine();
            Console.WriteLine("n:");
            n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedString.repeatedString(s, n);

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

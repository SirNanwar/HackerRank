using HackerRank.DictionaryAndHashMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises.DictionaryAndHashMaps
{
    public class FrequencyQueriesApp : IGenericDictionaryExercise
    {
        private long a;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("Number of queries:");
            a = long.Parse(Console.ReadLine());

            List<List<int>> d = new List<List<int>>();
            
            Console.WriteLine("Queries:");
            for (int i = 0; i < a; i++)
            {
                d[i] = new List<int>(System.Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp)));
            }

            List<int> result = FrequencyQueries.freqQuery(d);

            Console.WriteLine();
            Console.WriteLine("Result:");
            foreach(var c in result)
                Console.WriteLine(c);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("You are given q queries. Each query " +
                "is of the form two integers described below:");
            Console.WriteLine("-1 x: Insert x in your data structure.");
            Console.WriteLine("-2 y: Delete one occurence of y from your data structure, if present.");
            Console.WriteLine("-  : Check if any integer is present whose frequency is exactly . " +
                "If yes, print 1 else 0.");
            Console.WriteLine("The queries are given in the form of a " +
                "2-D array queries of size q where queries[i][0] " +
                "contains the operation, and queries[i][1] contains " +
                "the data element. For example, you are given array " +
                "queries = [(1,1),(2,2),(3,2),(1,1),(1,1),(2,1),(3,2)]." +
                " The results of each operation are:");
            Console.WriteLine("Operation   Array   Output" + Environment.NewLine +
                " (1,1)       [1]" + Environment.NewLine +
                " (2,2)       [1]" + Environment.NewLine +
                " (3,2)                   0" + Environment.NewLine +
                " (1,1)       [1,1]" + Environment.NewLine +
                " (1,1)       [1,1,1]" + Environment.NewLine +
                " (2,1)       [1,1]" + Environment.NewLine +
                " (3,2)                   1");
            Program.AddSeparator();
        }
    }
}

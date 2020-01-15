using HackerRank.Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises.Array
{
    class ArrayManipulationApp : IGenericArrayExercise
    {
        private int[][] arr;

        public void Run()
        {
            PrintProblem();
            int[] a;
            Console.WriteLine("size: operations:");
            a = System.Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            arr = new int[a[1]][];
            Console.WriteLine("matrix:");
            for (int i = 0; i < a[1]; i++)
            {
                arr[i] = System.Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = ArrayManipulation.arrayManipulation(a[0], a[1], arr);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("Starting with a 1-indexed array of zeros and a list of operations," +
                " for each operation add a value to each of the array element between" +
                " two given indices, inclusive. " +
                "Once all operations have been performed, " +
                "return the maximum value in your array.");
            Program.AddSeparator();
        }
    }
}

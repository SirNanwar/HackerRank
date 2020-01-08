using HackerRank.Warm_up_Challenges;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises
{
    class SockMerchantApp : IGenericWarmUpExercise
    {
        private int numberOfSocks;
        private int[] colors;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("Number of socks:");
            numberOfSocks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Colors:");
            colors = System.Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = SockMerchant.sockMerchant(numberOfSocks, colors);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.");
            Console.WriteLine("For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .");
            Console.WriteLine();
            Console.WriteLine("Function Description");
            Console.WriteLine("Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.");
            Console.WriteLine("sockMerchant has the following parameter(s):");
            Console.WriteLine("n: the number of socks in the pile");
            Console.WriteLine("ar: the colors of each sock");
            Console.WriteLine();
            Console.WriteLine("Input Format");
            Console.WriteLine("The first line contains an integer , the number of socks represented in .");
            Console.WriteLine("The second line contains  space-separated integers describing the colors  of the socks in the pile.");
            Console.WriteLine();
            Console.WriteLine("Output Format");
            Console.WriteLine("Return the total number of matching pairs of socks that John can sell.");
            Program.AddSeparator();
        }
    }
}

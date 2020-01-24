using HackerRank.DictionaryAndHashMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.Exercises.DictionaryAndHashMaps
{
    public class RansomNoteApp : IGenericDictionaryExercise
    {
        private long[] a;
        private string[] d;
        private string[] e;

        public void Run()
        {
            PrintProblem();

            Console.WriteLine("words on magazine: number of words on note:");
            a = System.Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt64(aTemp));
            Console.WriteLine("Magazine:");
            d = Console.ReadLine().Split(' ');
            Console.WriteLine("Note:");
            e = Console.ReadLine().Split(' ');

            string result = RansomNote.checkMagazine(d, e);

            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public void PrintProblem()
        {
            Program.Clean();
            Console.WriteLine("Harold is a kidnapper who " +
                "wrote a ransom note, but now he is worried it " +
                "will be traced back to him through his " +
                "handwriting. He found a magazine and wants to " +
                "know if he can cut out whole words from it and " +
                "use them to create an untraceable replica of " +
                "his ransom note. The words in his note are " +
                "case sensitive and he must use only whole" +
                " words available in the magazine. " +
                "He cannot use substrings or concatenation " +
                "to create the words he needs. " +
                Environment.NewLine +
                "Given the words in the magazine and the words " +
                "in the ransom note, print Yes if he can " +
                "replicate his ransom note exactly using " +
                "whole words from the magazine; " +
                "otherwise, print No. " +
                Environment.NewLine +
                "For example, the note is \"Attack at dawn\". " +
                "The magazine contains only \"attack at dawn\". " +
                "The magazine has all the right words, " +
                "but there's a case mismatch. The answer is No.");
            Program.AddSeparator();
        }
    }
}

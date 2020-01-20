using HackerRankApp.Exercises;
using HackerRankApp.Exercises.Array;
using HackerRankApp.Exercises.DictionaryAndHashMaps;
using System;

namespace HackerRankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the first draft of Hacker Rank exercises, using my solutions." + 
                              Environment.NewLine +
                              "Have fun.");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            Init();
            Exit();
        }

        private static void Init()
        {
            IGenericExercise exerc = null;

            Clean();

            Console.WriteLine("To start, please select which exercise group you wish to try:");
            ListExerciseGroups();

            AddSeparator();
            do
            {
                string key = Console.ReadLine();
                switch (key)
                {
                    case "0":
                    case "Exit":
                        Exit();
                        return;
                    case "1":
                    case "Warm-up Challenges":
                        SelectWarmUp(exerc as IGenericWarmUpExercise);
                        return;
                    case "2":
                    case "Arrays":
                        SelectArray(exerc as IGenericArrayExercise);
                        return;
                    case "3":
                    case "Dictionaries and Hash Maps":
                        SelectDictionary(exerc as IGenericDictionaryExercise);
                        return;
                    default:
                        Console.WriteLine("Unknown group, please try again." +
                                           Environment.NewLine);
                        break;
                }
            } while (true);
        }

        private static void Exit()
        {
            Clean();

            Console.WriteLine("Bye!");
            Console.WriteLine("Press any key to leave");
            Console.ReadKey();
        }

        private static void SelectDictionary(IGenericDictionaryExercise genericDictionaryExercise)
        {
            Clean();
            Console.WriteLine("Dictionary and Hash Map Exercises Selected");
            AddSeparator();
            Console.WriteLine("Please select exercise:");
            Console.WriteLine("0 - Return");
            Console.WriteLine("1 - Counting Triplets");
            AddSeparator();

            do 
            {
                string key = Console.ReadLine();
                switch (key) 
                {
                    case "0":
                    case "Return":
                        Init();
                        return;
                    case "1":
                    case "Counting Triplets":
                        genericDictionaryExercise = new CountTripletsApp();
                        genericDictionaryExercise.Run();
                        return;
                    default:
                        Console.WriteLine("Unknown exercise, please try again." +
                                          Environment.NewLine);
                        break;
                }
            } while (true);
        }

        private static void SelectArray(IGenericArrayExercise genericArrayExercise)
        {
            Clean();
            Console.WriteLine("Array Exercises Selected");
            AddSeparator();
            Console.WriteLine("Please select an exercise:");
            Console.WriteLine("0 - Return");
            Console.WriteLine("1 - 2D Array DS");
            Console.WriteLine("2 - Left Rotation");
            Console.WriteLine("3 - New Year Chaos");
            Console.WriteLine("4 - Minimum Swaps");
            Console.WriteLine("5 - Array Manipulation");
            AddSeparator();

            do
            {
                string key = Console.ReadLine();
                switch (key)
                {
                    case "0":
                    case "Return":
                        Init();
                        return;
                    case "1":
                    case "2D Array DS":
                        genericArrayExercise = new _2DArraysDSApp();
                        genericArrayExercise.Run();
                        return;
                    case "2":
                    case "Left Rotation":
                        genericArrayExercise = new LeftRotationApp();
                        genericArrayExercise.Run();
                        return;
                    case "3":
                    case "New Year Chaos":
                        genericArrayExercise = new NewYearChaosApp();
                        genericArrayExercise.Run();
                        return;
                    case "4":
                    case "Minimum Swaps":
                        genericArrayExercise = new MinimumSwapsApp();
                        genericArrayExercise.Run();
                        return;
                    case "5":
                    case "Array Manipulation":
                        genericArrayExercise = new ArrayManipulationApp();
                        genericArrayExercise.Run();
                        return;
                    default:
                        Console.WriteLine("Unknown exercise, please try again." +
                                          Environment.NewLine);
                        break;
                }
            } while (true);
        }

        private static void SelectWarmUp(IGenericWarmUpExercise genericArrayExercise)
        {
            Clean();
            Console.WriteLine("Warm-Up Exercises Selected");
            AddSeparator();
            Console.WriteLine("Please select an exercise:");
            Console.WriteLine("0 - Return");
            Console.WriteLine("1 - Sock Merchant");
            Console.WriteLine("2 - Repeated String");
            Console.WriteLine("3 - Jumping on the Clouds");
            Console.WriteLine("4 - Counting Valleys");
            AddSeparator();

            do
            {
                string key = Console.ReadLine();
                switch (key)
                {
                    case "0":
                    case "Return":
                        Init();
                        return;
                    case "1":
                    case "Sock Merchant":
                        genericArrayExercise = new SockMerchantApp();
                        genericArrayExercise.Run();
                        return;
                    case "2":
                    case "Repeated String":
                        genericArrayExercise = new RepeatedStringApp();
                        genericArrayExercise.Run();
                        return;
                    case "3":
                    case "Jumping on the Clouds":
                        Clean();
                        genericArrayExercise = new JumpingOnTheCloudsApp();
                        genericArrayExercise.Run();
                        return;
                    case "4":
                    case "Counting Valleys":
                        genericArrayExercise = new CountingValleysApp();
                        genericArrayExercise.Run();
                        return;
                    default:
                        Console.WriteLine("Unknown exercise, please try again." + 
                                          Environment.NewLine);
                        break;
                }
            } while (true);
        }

        public static void Clean()
        {
            Console.Clear();
            AddSeparator();
        }
        public static void AddSeparator()
        {
            Console.WriteLine();
            Console.WriteLine("---+----+----+----+----+----+----+----+----+----+---+----+----+----+----+----+----+----+----+----+");
            Console.WriteLine();
        }

        private static void ListExerciseGroups()
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Warm-up Challenges");
            Console.WriteLine("2 - Arrays");
            Console.WriteLine("3 - Dictionaries and Hash Maps");
        }
    }
}

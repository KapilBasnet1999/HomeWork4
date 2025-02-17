// Written by Kapil
// Feb 16 2025

using System;
using System.Collections.Generic;

namespace HomeWork4
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            // Displaying available tasks to the user
            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. Word Count");
            Console.WriteLine("2. Flip End Characters");
            Console.WriteLine("3. Check if Characters Are in Order");
            Console.WriteLine("4. First N Vowels");
            Console.WriteLine("5. Change Every Letter to the Next Letter");

            // Read user input for task choice
            Console.Write("\nSelect an Option between 1-5:");
            int taskChoice = int.Parse(Console.ReadLine()) - 1; // Subtract 1 to match index

            // Make sure task number is valid
            if (taskChoice >= 0 && taskChoice < 5)
            {
                // Call the method based on the task choice
                switch (taskChoice)
                {
                    case 0:
                        CountWordsTask();
                        break;
                    case 1:
                        FlipEndCharsTask();
                        break;
                    case 2:
                        IsInOrderTask();
                        break;
                    case 3:
                        FirstNVowelsTask();
                        break;
                    case 4:
                        MoveLettersTask();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        // 1. Word Count Task
        private static void CountWordsTask()
        {
            Console.Write("\nEnter a sentence to count the words:");
            string inputSentence = Console.ReadLine();
            Homework homework = new Homework(inputSentence, "", 0, "");
            Console.WriteLine($"Word count: {homework.CountWords()}");
        }

        // 2. Flip End Characters Task
        private static void FlipEndCharsTask()
        {
            Console.Write("\nEnter a string to flip the first and last characters:");
            string inputString = Console.ReadLine();
            Homework homework = new Homework("", inputString, 0, "");
            Console.WriteLine($"Result: {homework.FlipEndChars()}");
        }

        // 3. Check if Characters Are in Order Task
        private static void IsInOrderTask()
        {
            Console.Write("\nEnter a string to check if the characters are in order:");
            string inputStr = Console.ReadLine();
            Homework homework = new Homework("", "", 0, inputStr);
            Console.WriteLine($"Is in order: {homework.IsInOrder()}");
        }

        // 4. First N Vowels Task
        private static void FirstNVowelsTask()
        {
            Console.Write("\nEnter a string to extract vowels and specify how many vowels to extract:");
            string inputStr = Console.ReadLine();
            Console.Write("Enter the number of vowels to extract:");
            int nVowels = int.Parse(Console.ReadLine());
            Homework homework = new Homework("", "", nVowels, inputStr);
            Console.WriteLine($"First {nVowels} vowels: {homework.FirstNVowels()}");
        }

        // 5. Change Every Letter to the Next Letter Task
        private static void MoveLettersTask()
        {
            Console.Write("\nEnter a string to change every letter to the next letter:");
            string inputStr = Console.ReadLine();
            Homework homework = new Homework("", "", 0, inputStr);
            Console.WriteLine($"Changed string: {homework.MoveLetters()}");
        }
    }
}

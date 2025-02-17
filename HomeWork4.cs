// Written by Kapil
// Feb 16 2025

using System;
using System.Linq;

namespace HomeWork4
{
    public class Homework
    {
        // Private variables
        private string sentence= "n/a";
        private string inputString = "n/a";
        private int nVowels = -1;
        private string inputStr = "n/a";

        // Properties (Getters and Setters)
        public string Sentence
        {
            get { return this.sentence; }
            set { this.sentence = value; }
        }

        public string InputString
        {
            get { return this.inputString; }
            set { this.inputString = value; }
        }

        public int NVowels
        {
            get { return this.nVowels; }
            set { this.nVowels = value; }
        }

        public string InputStr
        {
            get { return this.inputStr; }
            set { this.inputStr = value; }
        }

        // Constructor
        public Homework(string sentence, string inputString, int nVowels, string inputStr)
        {
            this.Sentence = sentence;
            this.InputString = inputString;
            this.NVowels = nVowels;
            this.InputStr = inputStr;
        }

        // 1) Count words in a sentence
        public int CountWords()
        {
            if (string.IsNullOrEmpty(Sentence))
            {
                return 0; // Return 0 if sentence is empty or null
            }
            return Sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // 2) Swap first and last characters of the input string
        public string FlipEndChars()
        {
            if (string.IsNullOrEmpty(InputString) || InputString.Length < 2)
            {
                return "Incompatible."; // If string length is less than 2
            }

            if (InputString[0] == InputString[InputString.Length - 1])
            {
                return "Two's a pair."; // If first and last characters are the same
            }

            char[] chars = InputString.ToCharArray();
            char temp = chars[0];
            chars[0] = chars[InputString.Length - 1];
            chars[InputString.Length - 1] = temp;
            return new string(chars);
        }

        // 3) Check if characters are in order
        public bool IsInOrder()
        {
            string sortedString = string.Concat(InputStr.OrderBy(c => c));
            return InputStr == sortedString;
        }

        // 4) Return the first N vowels of the input string
        public string FirstNVowels()
        {
            string vowels = "aeiou";
            string result = new string(InputStr.Where(c => vowels.Contains(c)).ToArray());
            return result.Length >= NVowels ? result.Substring(0, NVowels) : "invalid";
        }

        // 5) Change every letter in the string to the next letter
        public string MoveLetters()
        {
            char[] result = new char[InputStr.Length];
            for (int i = 0; i < InputStr.Length; i++)
            {
                if (char.IsLower(InputStr[i]))
                {
                    result[i] = (char)(InputStr[i] + 1);
                }
                else
                {
                    result[i] = InputStr[i];
                }
            }
            return new string(result);
        }

        // Overriding ToString method 
        public override string ToString()
        {
            string message = "";
            message += "Input String: " + this.InputString + "\n";
            message += "Sentence: " + this.Sentence + "\n";
            message += "N Vowels: " + this.NVowels + "\n";
            message += "Input String for Transformation: " + this.InputStr + "\n";
            return message;
        }
    }
}

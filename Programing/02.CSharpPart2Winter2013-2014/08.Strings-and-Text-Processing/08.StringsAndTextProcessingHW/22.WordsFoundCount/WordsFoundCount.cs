namespace _22.WordsFoundCount
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class WordsFoundCount
    {
        //22.Write a program that reads a string from the console and lists all 
        //different words in the string along with information how many times each word is found.

        static void Main()
        {
            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.".ToLower();

            var words = Regex.Matches(text, @"\w+");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (Match word in words)
            {
                if (wordsCount.ContainsKey(word.Value))
                {
                    wordsCount[word.Value]++;
                }
                else
                {
                    wordsCount.Add(word.Value, 1);
                }
            }

            foreach (var wordCount in wordsCount)
            {
                Console.WriteLine("{0} -> {1} times.", wordCount.Key, wordCount.Value);
            }
        }
    }
}

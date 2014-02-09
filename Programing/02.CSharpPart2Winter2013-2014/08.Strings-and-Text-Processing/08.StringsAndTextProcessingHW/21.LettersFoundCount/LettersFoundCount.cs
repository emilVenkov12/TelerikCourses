namespace _21.LettersFoundCount
{
    using System;
    using System.Collections.Generic;

    class LettersFoundCount
    {
        //21.Write a program that reads a string from the console and prints all 
        //different letters in the string along with information how many times each letter is found. 

        static void Main()
        {
            string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.".ToLower();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsLetter(currentChar))
                {
                    if (lettersCount.ContainsKey(currentChar))
                    {
                        lettersCount[currentChar]++;
                    }
                    else
                    {
                        lettersCount.Add(currentChar, 1);
                    }
                }
            }

            foreach (var letterCount in lettersCount)
            {
                Console.WriteLine("{0} -> {1} times.", letterCount.Key, letterCount.Value);
            }
        }
    }
}

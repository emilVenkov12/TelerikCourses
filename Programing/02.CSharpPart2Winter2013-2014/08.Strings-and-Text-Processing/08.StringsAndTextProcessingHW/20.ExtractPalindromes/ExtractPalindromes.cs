namespace _20.ExtractPalindromes
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractPalindromes
    {
        //20.Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

        static void Main()
        {
            string text = "Write aba program that extracts frf a given text alla palindromes, e.g. ABBA, lamal, exe";
            //a think one letter should be accepted as palindom too

            var words = Regex.Matches(text, @"\w+");

            foreach (Match word in words)
            {
                if (IsPalindrome(word.Value))
                {
                    Console.WriteLine(word.Value);
                }
            }
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1- i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

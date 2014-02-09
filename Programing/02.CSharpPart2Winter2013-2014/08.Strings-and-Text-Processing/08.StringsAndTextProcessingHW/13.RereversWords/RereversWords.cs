namespace _13.RereversWords
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Text;

    class RereversWords
    {
        //13.Write a program that reverses the words in given sentence.
	    //Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi! Test 1, 2,3";

            string matchWordsPattern = @"[\w\+\#-]+";

            string[] separators = Regex.Split(sentence, matchWordsPattern);

            string[] words = Regex.Matches(sentence, matchWordsPattern).Cast<Match>()
                .Select(m => m.Groups[0].Value).ToArray();
            Array.Reverse(words);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < Math.Max(separators.Length, words.Length); i++)
            {
                output.AppendFormat("{0}{1}",
                    i < separators.Length ? separators[i] : "",
                    i < words.Length ? words[i] : "");
            }

            Console.WriteLine(sentence);
            Console.WriteLine(output.ToString());
        }
    }
}

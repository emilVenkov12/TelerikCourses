namespace _08.ExtracsSentencesFromText
{
    using System;
    using System.Text.RegularExpressions;

    class ExtracsSentencesFromText
    {
        //08.Write a program that extracts from a given text all sentences containing given word.

        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it In 5 days.";
            string word = "in";

            string pattern = @"\s*[^\.]*\b" + word + @"\b.*?\.";
            var matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}

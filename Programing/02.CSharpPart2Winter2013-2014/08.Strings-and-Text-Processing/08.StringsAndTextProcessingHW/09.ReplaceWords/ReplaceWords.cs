namespace _09.ReplaceWords
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ReplaceWords
    {
        //09.We are given a string containing a list of forbidden words and a text containing
        //some of these words. Write a program that replaces the forbidden words with asterisks. 

        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            List<string> forbidenWords = new List<string>() { "Microsoft", "PHP", "CLR"};

            for (int i = 0; i < forbidenWords.Count; i++)
            {
                text = Regex.Replace(text, forbidenWords[i], m => new String('*', m.Length));
            }
            Console.WriteLine(text);
        }
    }
}

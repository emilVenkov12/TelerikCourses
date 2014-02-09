namespace _23.ReplaceChars
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceChars
    {
        //23.Write a program that reads a string from the console and replaces 
        //all series of consecutive identical letters with a single one.
        //Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";

            string pattern = @"(\w)\1+";

            input = Regex.Replace(input, pattern, "$1");

            Console.WriteLine(input);
        }
    }
}

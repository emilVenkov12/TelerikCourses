namespace _04.FindsSubstringOccurenceCount
{
    using System;
    using System.Text.RegularExpressions;

    class FindsSubstringOccurenceCount
    {
        //04.Write a program that finds how many times a substring is 
        //contained in a given text (perform case insensitive search).

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();

            #endregion

            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it ,in 5 days.";
            string substr = "in",
                pattern = substr;

            Console.WriteLine("\"{0}\" appearance count: {1}", substr, 
                Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count);
        }
    }
}

namespace _05.ParseGivenTag
{
    using System;
    using System.Text.RegularExpressions;

    class ParseGivenTag
    {
        //05.You are given a text. Write a program that changes the text in all regions 
        //surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();

            #endregion

            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string openTag = "<upcase>",
                closeTag = "</upcase>";
            string pattern = openTag + @"(.*?)" + closeTag;
            Regex regex = new Regex(pattern);
            Console.WriteLine("Result: {0}", regex.Replace(text, m => m.Groups[1].Value.ToUpper()));
        }
    }
}

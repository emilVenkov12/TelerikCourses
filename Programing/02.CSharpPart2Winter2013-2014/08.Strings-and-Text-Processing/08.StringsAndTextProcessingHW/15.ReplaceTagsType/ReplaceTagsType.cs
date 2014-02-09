namespace _15.ReplaceTagsType
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ReplaceTagsType
    {
        //15.Write a program that replaces in a HTML document given as string all 
        //the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:

        static void Main()
        {
            string htmlText = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            string pattern = @"<a href=""(.*?)"">(.*?)</a>";

            htmlText = Regex.Replace(htmlText, pattern, @"[URL=$1]$2[/URL]");

            Console.WriteLine(htmlText);
        }
    }
}

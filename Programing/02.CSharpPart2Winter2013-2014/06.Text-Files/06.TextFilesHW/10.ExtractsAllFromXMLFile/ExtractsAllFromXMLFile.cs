namespace _10.ExtractsAllFromXMLFile
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ExtractsAllFromXMLFile
    {
        //10.Write a program that extracts from given XML file all the text without the tags. 

        static void Main()
        {
            using (StreamReader srInputFile = new StreamReader(@"../../textFiles\inputFile.txt"))
            {
                string allText = srInputFile.ReadToEnd();

                string pattern = @">[^<>]+<";
                var matches = Regex.Matches(allText, pattern);
                foreach (var match in matches)
                {
                    Console.WriteLine("{0}", match.ToString().Trim('<', '>'));
                }
            }
        }
    }
}

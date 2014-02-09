namespace _07._08.ReplaceSubstingsAndWords
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceSubstingsAndWords
    {
        //07.Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

        //08.Modify the solution of the previous problem to replace only whole words (not substrings).

        static void Main()
        {
            using (StreamReader srInputFile = new StreamReader(@"../../textFiles\inputFile.txt"))
            {
                string allText = srInputFile.ReadToEnd();
                using (StreamWriter swOutputFile = new StreamWriter(@"../../textFiles\outputFile.txt"))
                {
                    string pattern = @"start"; // ex 7
                    //string pattern = @"\bstart\b"; //ex 8
                    swOutputFile.Write(Regex.Replace(allText, pattern, "finish"));
                    try
                    {
                        OpenFile(@"../../textFiles\outputFile.txt");
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("A problem occurs while trying to open the file, {0}", e.Message);
                    }
                }
            }
            
        }

        public static void OpenFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
            System.Diagnostics.Process.Start(fileName);
        }
    }
}

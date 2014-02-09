namespace _13.CountGivenWordsInFile
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class CountGivenWordsInFile
    {
        //13.Write a program that reads a list of words from a file words.txt and 
        //finds how many times each of the words is contained in another file test.txt. 
        //The result should be written in the file result.txt and the words should be sorted
        //by the number of their occurrences in descending order. Handle all possible exceptions in your methods.

        static void Main()
        {
            try
            {
                string allText = File.ReadAllText(@"../../textFiles\inputFile.txt");
                string[] words = File.ReadAllLines(@"../../textFiles\words.txt");
                int[] occurensCount = new int[words.Length];

                using (StreamWriter swResFile = new StreamWriter(@"../../textFiles\result.txt"))
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        string pattern = @"\b" + words[i] + @"\b";
                        occurensCount[i] = Regex.Matches(allText, pattern).Count;
                        swResFile.WriteLine("{0} -> {1}", words[i], occurensCount[i]);
                    }
                }

                OpenFile(@"../../textFiles\result.txt");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("A problem occurs while trying to read from the file, {0}", e.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine("The given file path is too long.", ptle.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("Missing directory.", dnfe.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine("Unauthorized accsess to the file.", uae.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Given file is missing.", fnfe.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine("Unsupported file type.", nse.Message);
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

namespace _12.RemoveGivenWordsFromFile
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class RemoveGivenWordsFromFile
    {
        //12.Write a program that removes from a text file all words listed
        //in given another text file. Handle all possible exceptions in your methods.

        static void Main()
        {
            try
            {
                string allText = File.ReadAllText(@"../../textFiles\inputFile.txt");
                string[] words = File.ReadAllLines(@"../../textFiles\words.txt");

                for (int i = 0; i < words.Length; i++)
                {
                    string pattern = @"\b" + words[i] + @"\b";
                    allText = Regex.Replace(allText, pattern, String.Empty);
                }

                File.WriteAllText(@"../../textFiles\inputFile.txt", allText);

                OpenFile(@"../../textFiles\inputFile.txt");
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

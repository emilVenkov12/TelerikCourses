namespace _11.DeleteWordsWithGivenPrefix
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class DeleteWordsWithGivenPrefix
    {
        //11.Write a program that deletes from a text file all words that 
        //start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

        static void Main()
        {
            string text = String.Empty;            

            using (StreamReader srInputFile = new StreamReader(@"../../textFiles\inputFile.txt"))
            {
                text = srInputFile.ReadToEnd();
            }
            using (StreamWriter swInputFile = new StreamWriter(@"../../textFiles\inputFile.txt"))
            {

                string prefix = "text",
                    pattern = @"\b" + prefix + @"\w+";

                string newText = Regex.Replace(text, pattern, String.Empty);
                swInputFile.Write(newText);
            }
            try
            {
                OpenFile(@"../../textFiles\inputFile.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("A problem occurs while trying to open the file, {0}", e.Message);
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

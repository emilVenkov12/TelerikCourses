namespace _09.DeletesOddLinesFromFile
{
    using System;
    using System.IO;
    using System.Text;

    class DeletesOddLinesFromFile
    {
        //09.Write a program that deletes from given text file all odd lines. The result should be in the same file.

        static void Main()
        {
            StringBuilder evenLines = new StringBuilder();

            using (StreamReader srInputFile = new StreamReader(@"../../textFiles\inputFile.txt"))
            {
                int lineNumber = 1;
                for (string line; (line = srInputFile.ReadLine()) != null; lineNumber++)
                {
                    if (lineNumber % 2 == 0)
                    {
                        evenLines.AppendLine(line);
                    }
                }
            }
            using (StreamWriter swInputFile = new StreamWriter(@"../../textFiles\inputFile.txt"))
            {
                swInputFile.Write(evenLines.ToString());
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

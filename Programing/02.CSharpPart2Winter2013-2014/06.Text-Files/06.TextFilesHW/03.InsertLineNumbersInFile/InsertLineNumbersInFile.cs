namespace _03.InsertLineNumbersInFile
{
    using System;
    using System.IO;

    class InsertLineNumbersInFile
    {
        //03.Write a program that reads a text file and inserts line numbers 
        //in front of each of its lines. The result should be written to another text file.

        static void Main()
        {
            using (StreamReader sr = new StreamReader("../../InsertLineNumbersInFile.cs"))
            {
                using (StreamWriter swResFile = new StreamWriter(@"../../textFiles\resFile.txt"))
                {
                    string line = sr.ReadLine();
                    int lineNumber = 1;
                    while (line != null)
                    {
                        swResFile.WriteLine("{0}  {1}", lineNumber, line);
                        lineNumber++;
                        line = sr.ReadLine();
                    }
                    try
                    {
                        OpenFile(@"../../textFiles\resFile.txt");
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

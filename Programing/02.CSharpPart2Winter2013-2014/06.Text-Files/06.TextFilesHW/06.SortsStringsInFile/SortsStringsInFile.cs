namespace _06.SortsStringsInFile
{
    using System;
    using System.IO;
    using System.Linq;

    class SortsStringsInFile
    {
        //06.Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

        static void Main()
        {
            using (StreamReader srInputFile = new StreamReader(@"../../textFiles\inputFile.txt"))
            {
                using (StreamWriter swResFile = new StreamWriter(@"../../textFiles\resFile.txt"))
                {
                    swResFile.Write(String.Join("\n", 
                        srInputFile.ReadToEnd()
                        .Split(new char[]{ '\n' }, StringSplitOptions.RemoveEmptyEntries)
                        .OrderBy(x => x)));
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

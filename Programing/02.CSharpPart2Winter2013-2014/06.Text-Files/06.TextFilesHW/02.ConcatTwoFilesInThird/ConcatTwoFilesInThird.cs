namespace _02.ConcatTwoFilesInThird
{
    using System;
    using System.IO;
    class ConcatTwoFilesInThird
    {
        //02.Write a program that concatenates two text files into another text file.

        static void Main()
        {
            
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            using (StreamReader srFirstFile = new StreamReader(@"../../textFiles\firstFile.txt", encoding))
            {
                using (StreamReader srSecondFile = new StreamReader(@"../../textFiles\secondFile.txt", encoding))
                {
                    using (StreamWriter swThirdFile = new StreamWriter(@"../../textFiles\thirdFile.txt", false, encoding))
                    {
                        swThirdFile.WriteLine(srFirstFile.ReadToEnd() + srSecondFile.ReadToEnd());
                        try
                        {
                            OpenFile(@"../../textFiles\thirdFile.txt");
                        }
                        catch (FileNotFoundException e)
                        {
                            Console.WriteLine("A problem occurs while trying to open the file, {0}", e.Message);
                        }
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

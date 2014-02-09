namespace _04.ComparingTwoTxtFiles
{
    using System;
    using System.IO;

    class ComparingTwoTxtFiles
    {
        //04.Write a program that compares two text files line by line and prints the number of 
        //lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

        static void Main()
        {
            int equalLines = 0,
                notEqualLines = 0;

            using (StreamReader srFirstFile = new StreamReader(@"../../textFiles\firstFile.txt"))
            {
                using (StreamReader srSecFile = new StreamReader(@"../../textFiles\secFile.txt"))
                {
                    string firstFileLine = srFirstFile.ReadLine(),
                        secFileLine = srSecFile.ReadLine();

                    while (firstFileLine != null && secFileLine != null)
                    {
                        if (firstFileLine == secFileLine)
                        {
                            equalLines++;
                        }
                        else
                        {
                            notEqualLines++;
                        }
                        firstFileLine = srFirstFile.ReadLine();
                        secFileLine = srSecFile.ReadLine();
                    }

                    Console.WriteLine("Same lines number : {0}, diffrent lines number: {1}", equalLines, notEqualLines);
                }
            }
        }
    }
}

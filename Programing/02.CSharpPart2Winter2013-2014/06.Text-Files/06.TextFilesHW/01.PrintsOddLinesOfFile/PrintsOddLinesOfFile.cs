namespace _01.PrintsOddLinesOfFile
{
    using System;
    using System.IO;

    class PrintsOddLinesOfFile
    {
        //01.Write a program that reads a text file and prints on the console its odd lines.

        static void Main()
        {
            using (StreamReader sr = new StreamReader("../../PrintsOddLinesOfFile.cs"))
            {
                string line = sr.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine("{0} : {1}", lineNumber, line);
                    }
                    lineNumber++;
                    line = sr.ReadLine();
                }
			}
        }
    }
}

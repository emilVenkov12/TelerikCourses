namespace _03.ReadsContentOfGivenFile
{
    using System;
    using System.IO;
    using System.Text;
    
    class ReadsContentOfGivenFile
    {
        //03.Write a program that enters file name along with its full file path 
        //(e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
        //Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

        static void Main()
        {
            string filePath = String.Empty;
            try
            {
                Console.Write("Enter file path: ");
                filePath = Console.ReadLine();
                string fileContent = File.ReadAllText(filePath, Encoding.GetEncoding("utf-8"));
                Console.WriteLine("File Content: {0}", fileContent);
            }
            catch (ArgumentException)
            {
                Console.WriteLine(
                    "Path is a zero-length string, contains only white space" +
                "or contains one or more invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. ");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Unsupported file type.");
            }
        }
    }
}

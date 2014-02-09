namespace _04.FTML
{
    using System;
    using System.Text;

    class FTML
    {
        static string revTagOpen = "<rev>";
        static string delTagOpen = "<del>";
        static string upperTagOpen = "<upper>";
        static string lowerTagOpen = "<lower>";
        static string toggleTagOpen = "<toggle>";

        static string revTagClose = "</rev>";
        static string delTagClose = "</del>";
        static string upperTagClose = "</upper>";
        static string lowerTagClose = "</lower>";
        static string toggleTagClose = "</toggle>";

        int openedDelTags = 0;



        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            StringBuilder input = new StringBuilder();

            for (int i = 0; i < linesCount; i++)
            {
                input.AppendLine(Console.ReadLine());
            }
            input.Length--;

            int inputLength = input.Length;
            
            Console.WriteLine(input.ToString());
        }
    }
}

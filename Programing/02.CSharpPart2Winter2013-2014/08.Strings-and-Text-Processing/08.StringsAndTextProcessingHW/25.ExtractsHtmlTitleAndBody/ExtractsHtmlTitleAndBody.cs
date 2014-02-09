namespace _25.ExtractsHtmlTitleAndBody
{
    using System;
    using System.IO;
    using System.Text;

    class ExtractsHtmlTitleAndBody
    {
        //25.Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 

        static void Main()
        {
            string htmlCode = File.ReadAllText(@"../../textFiles\index.html");

            int titleStartIndex = htmlCode.IndexOf("<title>");
            if (titleStartIndex != -1)
            {
                int titleEndIndex = htmlCode.IndexOf("</title>");
                Console.WriteLine("Title: {0}", 
                    htmlCode.Substring(titleStartIndex + 7, titleEndIndex - (titleStartIndex + 7)));
            }

            bool inTag = false;
            StringBuilder bodyText = new StringBuilder();

            //http://en.wikipedia.org/wiki/Finite-state_machine

            for (int i = htmlCode.IndexOf("<body>"); i < htmlCode.Length; i++)
            {
                if (htmlCode[i] == '<')
                {
                    inTag = true;
                    continue;
                }
                if (htmlCode[i] == '>')
                {
                    inTag = false;
                    continue;
                }
                if (!inTag)
                {
                    bodyText.Append(htmlCode[i] + "");
                }
            }

            Console.WriteLine(bodyText.ToString());

        }
    }
}

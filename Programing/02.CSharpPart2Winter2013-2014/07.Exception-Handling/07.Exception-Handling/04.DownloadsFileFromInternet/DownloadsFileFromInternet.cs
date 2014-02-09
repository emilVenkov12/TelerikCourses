namespace _04.DownloadsFileFromInternet
{
    using System;
    using System.Net;

    class DownloadsFileFromInternet
    {
        //Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
        //and stores it the current directory. Find in Google how to download files in C#. Be sure to catch
        //all exceptions and to free any used resources in the finally block.

        static void Main()
        {
            WebClient webClient = new WebClient();
            using (webClient)
            {
                try
                {
                    webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"../../logo.jpg");
                    Console.WriteLine("File downloaded successfully.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The given address is null.");
                }
                catch (WebException)
                {
                    Console.WriteLine("The address is invalid.");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}

namespace _12.ParseUrlAddress
{
    using System;
    using System.Text.RegularExpressions;

    class ParseUrlAddress
    {
        //12.Write a program that parses an URL address given in the format:
        //[protocol]://[server]/[resource]
        //and extracts from it the [protocol], [server] and [resource] elements. 
        //For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
        //[protocol] = "http"
        //[server] = "www.devbg.org"
        //[resource] = "/forum/index.php"

        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";

            string pattern = @"(.*)://(.*?)(/.*)";

            var match = Regex.Match(url, pattern);

            string protocol = match.Groups[1].Value;
            string server = match.Groups[2].Value;
            string resourse = match.Groups[3].Value;

            Console.WriteLine("[protocol] = \"{0}\"\n[server] = \"{1}\"\n[resourse] = \"{2}\"", 
                protocol, server, resourse);
        }
    }
}

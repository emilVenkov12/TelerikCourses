namespace _18.ExtractsAllEmails
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractsAllEmails
    {
        //18.Write a program for extracting all email addresses from given text.
        //All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

        static void Main()
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string pattern = @"\b([a-zA-z0-9_\.]+)@([a-zA-z0-9\.]+)\.([a-z]{2,4})\b";

            var mathedEmails = Regex.Matches(text, pattern);

            foreach (var email in mathedEmails)
            {
                Console.WriteLine(email.ToString());
            }
        }
    }
}

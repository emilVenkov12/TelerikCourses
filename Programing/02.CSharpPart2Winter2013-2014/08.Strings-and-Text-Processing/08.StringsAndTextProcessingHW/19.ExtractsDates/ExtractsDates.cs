namespace _19.ExtractsDates
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    class ExtractsDates
    {
        //19.Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        //Display them in the standard date format for Canada.

        static void Main()
        {
            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

            string pattern = @"\b([0-9]{2})\.([0-9]{2})\.([0-9]{4})\b";

            var dates = Regex.Matches(text, pattern);

            foreach (var date in dates)
            {
                DateTime parsedDate;

                if (DateTime.TryParseExact(date.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    Console.WriteLine(parsedDate.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern)); // prints only date whitout the time
                }
            }
        }
    }
}

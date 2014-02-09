namespace _17.PrintDateTime
{
    using System;
    using System.Globalization;
    using System.Threading;

    class PrintDateTime
    {
        //17.Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

        static void Main()
        {
            #region Manula input

            //Console.Write("Enter date and timie in format \n\tday.month.year hour:minute:second: ");
            //string dateTimeStr = Console.ReadLine();
            //DateTime dateTime = new DateTime();
            //while (!DateTime.TryParseExact(dateTimeStr, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            //{
            //    Console.Write("Enter valid date (day.month.year hour:minute:second)");
            //    dateTimeStr = Console.ReadLine();
            //}

            #endregion
            DateTime dateTime = DateTime.Now;

            dateTime = dateTime.AddHours(6);
            dateTime = dateTime.AddMinutes(30);


            Console.WriteLine("{0:d.MM.yyyy HH:mm:ss}", dateTime);

            Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("bg-BG");
            Console.WriteLine("Day of week is: {0}", dateTime.ToString("dddd"));
        }
    }
}

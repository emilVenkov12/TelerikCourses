namespace _16.DistanceBetweenDates
{
    using System;
    using System.Globalization;

    class DistanceBetweenDates
    {
        //16.Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
        static void Main()
        {
            #region Manula input

            //Console.Write("Enter first date in format day.month.year: ");
            //string firstDateStr = Console.ReadLine();
            //DateTime firstDate = new DateTime();
            //while (!DateTime.TryParseExact(firstDateStr, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out firstDate))
            //{
            //    Console.Write("Enter valid date (day.month.year)");
            //    firstDateStr = Console.ReadLine();
            //}

            //Console.Write("Enter second date in format day.month.year: ");
            //string secondDateStr = Console.ReadLine();
            //DateTime secondDate = new DateTime();
            //while (!DateTime.TryParseExact(secondDateStr, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out secondDate))
            //{
            //    Console.Write("Enter valid date (day.month.year)");
            //    secondDateStr = Console.ReadLine();
            //}
            
            #endregion

            DateTime firstDate = new DateTime(2014, 1, 12);
            DateTime secondDate = new DateTime(2014, 1, 1);

            Console.WriteLine("Distance: {0}", Math.Abs((firstDate - secondDate).TotalDays));
        }

    }
}

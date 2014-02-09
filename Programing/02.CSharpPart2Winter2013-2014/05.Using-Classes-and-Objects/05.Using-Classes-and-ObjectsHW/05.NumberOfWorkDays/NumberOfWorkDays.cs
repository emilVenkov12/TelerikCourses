namespace _05.NumberOfWorkDays
{
    using System;
    using System.Linq;

    class NumberOfWorkDays
    {
        //05.Write a method that calculates the number of workdays between 
        //today and given date, passed as parameter. Consider that workdays are 
        //all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

        static void Main()
        {
            int currentYear = DateTime.Now.Year;
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(currentYear, 1, 1),
                new DateTime(currentYear, 3, 3),
                new DateTime(currentYear, 5, 1),
                new DateTime(currentYear, 5, 2),
                new DateTime(currentYear, 5, 6),
                new DateTime(currentYear, 5, 24),
                new DateTime(currentYear, 9, 22),
                new DateTime(currentYear, 12, 24),
                new DateTime(currentYear, 12, 25),
                new DateTime(currentYear, 12, 26),
                new DateTime(currentYear, 12, 31),
            };
            DateTime beginDate = DateTime.Now;
            DateTime endDate = new DateTime(2014, 1, 1);

            Console.WriteLine(GetWorkDaysCount(beginDate, endDate, holidays));
        }
        static int GetWorkDaysCount(DateTime beginDate, DateTime endDate, DateTime[] holidays)
        {
            if (beginDate > endDate)
            {
                return GetWorkDaysCount(endDate, beginDate, holidays); // swap dates 
            }

            int workDays = 0;
            for (DateTime currentDay = beginDate.Date; currentDay.Date <= endDate.Date; currentDay = currentDay.AddDays(1))
            {
                if (currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday && 
                    !holidays.Contains(currentDay))
                {
                    workDays++;
                }
            }

            return workDays;
        }
    }
}

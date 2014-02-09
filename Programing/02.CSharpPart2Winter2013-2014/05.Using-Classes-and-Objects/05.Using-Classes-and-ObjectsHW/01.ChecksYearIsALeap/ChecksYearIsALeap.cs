namespace _01.ChecksYearIsALeap
{
    using System;

    class ChecksYearIsALeap
    {
        //01.Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

        static void Main()
        {
            #region Manual Input

            //int year = 0;
            //Console.Write("Enter year: ");
            //while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            //{
            //    Console.Write("Enter valid year: ");
            //}

            #endregion

            int year = 2016;

            Console.WriteLine("Is {0} a leap? - {1}", year, DateTime.IsLeapYear(year));
        }
    }
}

namespace _03.PrintsDayOfWeek
{
    using System;

    class PrintsDayOfWeek
    {
        //03.Write a program that prints to the console which day of the week is today. Use System.DateTime.

        static void Main()
        {
            Console.WriteLine("Today is {0}", DateTime.Now.DayOfWeek);
        }
    }
}

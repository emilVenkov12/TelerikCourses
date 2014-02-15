namespace _07.TimerTest
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    class TimerTest
    {
        //07.Using delegates write a class Timer that has can execute certain method at each t seconds.

        static void Main()
        {
            Timer timer = new Timer(100, new TimerDelegate(PrintOnConsole));
            timer.Start();
            Thread.Sleep(1000);
            timer.Stop();
            Console.WriteLine();

            timer.Start();
            Thread.Sleep(2000);
            timer.Stop();
        }

        public static void PrintOnConsole()
        {
            Console.WriteLine("Called by timer - {0}", DateTime.Now);
        }
    }
}

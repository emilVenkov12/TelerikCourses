namespace _08.Events
{
    using System;
    using System.Threading;

    class Events
    {
        static void Main()
        {
            Timer timer = new Timer(100);
            timer.TimerTick += (object sender, EventArgs e) => 
            { 
                Console.WriteLine("Called by the timer - {0}", DateTime.Now); 
            };

            timer.Start();
            Thread.Sleep(1000);
            timer.Stop();
            Console.WriteLine();
            timer.Start();
            Thread.Sleep(1000);
            timer.Stop();
        }
    }
}

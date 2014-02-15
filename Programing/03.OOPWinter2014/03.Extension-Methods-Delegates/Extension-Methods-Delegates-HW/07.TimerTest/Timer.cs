namespace _07.TimerTest
{
    using System;
    using System.Threading;

    class Timer
    {
        public TimerDelegate timerDelegate;

        private int miliseconds;
        private bool isActive;
        private Thread oThread;

        public int Miliseconds
        {
            get { return miliseconds; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("miliseconds");
                }
                miliseconds = value;
            }
        }

        public Timer(int miliseconds, TimerDelegate timerDelegate)
        {
            this.Miliseconds = miliseconds;
            this.timerDelegate = timerDelegate;
            this.isActive = false;
        }

        public void Start()
        {
            this.isActive = true;
            this.oThread = new Thread(() =>
            {
                while (this.isActive)
                {
                    Thread.Sleep(this.Miliseconds);
                    timerDelegate();
                }
            });
            this.oThread.Start();
        }

        public void Stop()
        {
            this.isActive = false;

            this.oThread.Abort();
        }
    }
}

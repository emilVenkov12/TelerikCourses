namespace _08.Events
{
    using System;
    using System.Threading;

    class Timer
    {
        #region Fields and Properties

        private int miliseconds;

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

        public event EventHandler TimerTick;

        private bool isActive;

        private Thread oThread;

        #endregion

        public Timer(int miliseconds)
        {
            this.Miliseconds = miliseconds;
        }

        protected virtual void OnTimerTick(EventArgs e)
        {
            if (TimerTick != null)
                TimerTick(this, e);
        }

        public void Start()
        {
            this.isActive = true;
            this.oThread = new Thread(() =>
            {
                while (this.isActive)
                {
                    Thread.Sleep(this.miliseconds);
                    OnTimerTick(new EventArgs());
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

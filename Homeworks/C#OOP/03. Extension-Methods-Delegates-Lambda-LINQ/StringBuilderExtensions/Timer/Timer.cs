namespace ExtensionMethodsDelegatesLambdaLINQ.Timer
{
    using StringBuilderExtensions.Timer;
    using System;
    using System.Threading;

    public class Timer
    {
        public EventHandler<TimerEventArgs> Task;

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public int Interval { get; private set; }

        public void Start()
        {
            if (this.Interval == 0 || this.Interval < 0)
            {
                throw new ArgumentException("Time interval cant be negative or zero!");
            }
            while (true)
            {

                if (Task != null)
                {
                    Thread.Sleep(this.Interval);

                    var args = new TimerEventArgs();
                    Task(this, args);
                }
            }
        }
    }
}
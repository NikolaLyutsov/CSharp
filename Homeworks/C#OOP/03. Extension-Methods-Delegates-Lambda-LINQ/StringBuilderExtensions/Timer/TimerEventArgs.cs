namespace StringBuilderExtensions.Timer
{
    using System;

    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs()
        {
            this.Time = DateTime.Now;
        }
        public DateTime Time { get; private set; }
    }
}

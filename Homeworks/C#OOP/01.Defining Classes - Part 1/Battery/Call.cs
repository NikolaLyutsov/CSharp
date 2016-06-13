namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        private string date;
        private string time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(string date, string time, string dialledPhoneNumber, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    this.date = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The date of the call cant be empty!");
                }
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    this.time = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The time of the call cant be empty!");
                }
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    this.dialledPhoneNumber = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The dialled phone number of the call cant be empty!");
                }
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                if (value >= 0)
                {
                    this.duration = value;
                }
                else
                {
                    throw new ArgumentException("The duration of the call cant be less than 0 seconds");
                }
            }
        }

        public override string ToString()
        {
            List<string> info = new List<string>();

            info.Add("Call Date - " + this.Date);
            info.Add("Call Time - " + this.Time);
            info.Add("Number Called - " + this.DialledPhoneNumber);
            info.Add("Call Duration - " + this.Duration);

            return String.Join(Environment.NewLine, info);
        }
    }
}
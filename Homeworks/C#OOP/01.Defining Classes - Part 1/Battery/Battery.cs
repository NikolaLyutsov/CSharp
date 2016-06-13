namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    public class Battery
    {
        private string model;
        private double hoursIddle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery(string model, double hoursIddle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIddle = hoursIddle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    this.model = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The model of the battery cant be empty!");
                }
            }
        }

        public double HoursIddle
        {
            get
            {
                return this.hoursIddle;
            }
            private set
            {
                if (value > 0)
                {
                    this.hoursIddle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours of iddle of the Battery cant be less or equal to zero!");
                }
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours of talk of the Battery cant be less or equal to zero!");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            List<string> info = new List<string>();

            info.Add("Model - " + this.Model);
            info.Add("Hours Iddle - " + this.HoursIddle);
            info.Add("Hours Talk - " + this.HoursTalk);
            info.Add("Type - " + this.BatteryType);

            return String.Join(Environment.NewLine, info);
        }
    }
}
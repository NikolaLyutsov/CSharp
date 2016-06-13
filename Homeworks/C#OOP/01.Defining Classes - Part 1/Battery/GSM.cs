namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class GSM
    {
        private static readonly GSM iPhone4S = new GSM("iPhone 4s", "Apple", 500, "Gosho",
                 new Battery("G5", 50, 100, BatteryType.NiMH), new Display(10, 500000));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer)
        {
            CallHistory = new List<Call>();
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
          : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
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
                    throw new IndexOutOfRangeException("The model of the phone cant be empty!");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (value != string.Empty && value != null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The manufacturer of the phone cant be empty!");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The price cant be smaller or equal to 0");
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value != string.Empty && value != null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The owner's of the phone cant be less than 1 symbol!");
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory { get; private set; }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void DeleteCall(int callIndex)
        {
            CallHistory.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal GetTotalCallPrice(decimal pricePerMinute)
        {
            decimal allCallsInSecs = (decimal)(this.CallHistory.Select(x => x.Duration).Sum());
            return pricePerMinute * (allCallsInSecs / 60.0m);
        }
        
        public override string ToString()
        {
            List<string> info = new List<string>();
            info.Add("****WELCOME****");
            info.Add("Model - " + this.Model);
            info.Add("Manufacturer - " + this.Manufacturer);

            if (this.Owner != null)
                info.Add("Owner - " + this.Owner);

            if (this.Price != 0)
                info.Add("Price - " + this.Price);

            if (this.Display != null)
                info.Add("---Display--- \n" + this.Display);

            if (this.Battery != null)
                info.Add("---Battery--- \n" + this.Battery);

            return String.Join(Environment.NewLine, info);

        }
    }
}
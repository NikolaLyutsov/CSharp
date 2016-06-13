namespace DefiningClassesPart1
{
    using System;
    using System.Collections.Generic;

    public class Display
    {
        private double size;
        private long numberOfColors;

        public Display(double size, long numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value > 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size of the Display cant be less or equal to zero!");
                }
            }
        }

        public long NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            private set
            {
                if (value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The size of the Display cant be less or equal to zero!");
                }
            }
        }

        public override string ToString()
        {
            List<string> info = new List<string>();

            info.Add("Size - " + this.Size);
            info.Add("Number Of Colors - " + this.NumberOfColors);

            return String.Join(Environment.NewLine, info);
        }
    }
}
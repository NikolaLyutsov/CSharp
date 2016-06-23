namespace Problem_2.Students_and_workers.Humans
{
    using System;

    public class Worker : Human
    {
        private const int MIN_WORK_HOURS = 1;
        private const int MAX_WORK_HOURS = 12;

        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                CheckIfNumberNegative(value, "Week salary cannot be negative");
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The Work Hours Per Day cannot be less than {0} and more than {1}!", MIN_WORK_HOURS, MAX_WORK_HOURS));
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (WorkHoursPerDay * 7);
        }

        private static void CheckIfNumberNegative(decimal num, string message)
        {
            if (num < 0)
            {
                throw new Exception(message);
            }
        }
    }
}
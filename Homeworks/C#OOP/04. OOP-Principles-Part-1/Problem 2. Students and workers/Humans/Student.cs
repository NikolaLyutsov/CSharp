namespace Problem_2.Students_and_workers.Humans
{
    using System;

    public class Student : Human
    {
        private const int MIN_GRADE = 2;
        private const int MAX_GRADE = 6;

        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < MIN_GRADE || value > MAX_GRADE)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The grade cannot be less than {0} or more than {1}!", MIN_GRADE, MAX_GRADE));
                }
                this.grade = value;
            }
        }
    }
}
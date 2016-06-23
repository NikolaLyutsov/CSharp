namespace Problem_2.Students_and_workers.Humans
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                CheckIfNullOrEmpty(value, "The first name cannot be null or empty!");
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                CheckIfNullOrEmpty(value, "The last name cannot be null or empty!");
                this.lastName = value;
            }
        }

        private static void CheckIfNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
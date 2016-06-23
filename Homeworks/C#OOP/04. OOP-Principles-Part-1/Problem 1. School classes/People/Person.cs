namespace Problem_1.School_classes.People
{
    using Interfaces;
    using ExceptionVerification;

    public abstract class Person : IName, IComment
    {
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Verification.CheckIfNullOrEmpty(value, "The name cannot be null or empty");
                this.name = value;
            }
        }
    }
}
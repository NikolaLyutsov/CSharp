namespace Problem_1.School_classes.People
{
    using Interfaces;
    using ExceptionVerification;

    public class Student : Person, IName, IComment
    {
        private int classNumber;

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                Verification.CheckIfNumberNegative(value, "The class number cant be negative number");
                this.classNumber = value;
            }
        }
    }
}
namespace Problem_1.School_classes.Disciplines
{
    using Interfaces;
    using Schools.ExceptionVerification;

    public class Discipline : IName, IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Verification.CheckIfNullOrEmpty(value, "The name of the discipline cant be empty!");
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                Verification.CheckIfNumberNegative(value, "The lectures cant be less than 0");
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            set
            {
                Verification.CheckIfNumberNegative(value, "The excersises cant be less than 0");
                this.numberOfExcercises = value;
            }
        }

        public string Comment { get; set; }
    }
}
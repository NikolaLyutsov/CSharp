namespace Problem_1.School_classes.SchoolClasses
{
    using System.Collections.Generic;
    using People;
    using Interfaces;
    using ExceptionVerification;
    public class SchoolClass : IComment
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string textID;

        public SchoolClass(string textID)
        {
            this.TextID = textID;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public SchoolClass(string textID, string comment) : this(textID)
        {
            this.Comment = comment;
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            private set
            {
                Verification.CheckIfNullOrEmpty(value, "The unique text id of the class cannot be empty!");
                this.textID = value;
            }
        }

        public string Comment { get; set; }

        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
            private set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
            private set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

    }
}
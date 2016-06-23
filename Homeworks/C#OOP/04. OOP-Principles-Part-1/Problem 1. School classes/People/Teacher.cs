namespace Problem_1.School_classes.People
{
    using System.Collections.Generic;
    using Disciplines;
    using Interfaces;

    public class Teacher : Person, IName, IComment
    {
        private List<Discipline> disciplines;

        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
            }
            private set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
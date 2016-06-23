namespace Problem_3.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : Isound
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must not be a negative number!");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Put some letters!!");
                }
                this.name = value;
            }
        }
     public Sex Sex { get; set; }

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            double averageAge = animals.Average(animal => animal.Age);
            return averageAge;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return string.Format("{0} is {1} years old.Its {2}", this.Name, this.Age, this.Sex);
        }
    }
}

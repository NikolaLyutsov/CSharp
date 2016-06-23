namespace Problem_3.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Tests
    {
        public static void Main()
        {
            Cat[] cats = new Cat[]
            {
                new Cat("Pesho", 2, Sex.male),
                new Cat("Gosho", 4, Sex.male),
                new Cat("Kina", 3, Sex.female),
                new Cat("Tom", 1, Sex.female),
                new Cat("Maca", 7, Sex.female),
            };

            Console.WriteLine("Cats:");

            foreach (var cat in cats)
            {
                Console.WriteLine(cat);
            }

            Console.WriteLine("\nAverage age of all cats is: {0}\n", Animal.CalculateAverageAge(cats));
            Console.WriteLine("Dogs:");

            Dog[] dogs = new Dog[]
            {
                new Dog("Chestur", 8, Sex.male),
                new Dog("Lorenco", 5, Sex.male),
                new Dog("Kruncho", 2, Sex.female),
                new Dog("Djerry", 2, Sex.female),
                new Dog("Merry", 11, Sex.female),
            };

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine("\nAverage age of all dogs is: {0}\n", Animal.CalculateAverageAge(dogs));

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Krunchi", 3),
                new Kitten("Merry", 1),
                new Kitten("Vivi", 8),
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Gosho", 2),
                new Tomcat("Pesho", 6),
            };

            var allAnimals = new List<Animal>();

            allAnimals.AddRange(tomcats);
            allAnimals.AddRange(kittens);
            allAnimals.AddRange(dogs);

            Console.WriteLine("Average age of all animals is: " + Animal.CalculateAverageAge(allAnimals));

            var dogsFromAll = from animal in allAnimals
                              where animal.GetType() == typeof(Dog)
                              select animal;

            Console.WriteLine("\nAverage age of all dogs from a list of all animals is :" + Animal.CalculateAverageAge(dogsFromAll));
        }
    }
}
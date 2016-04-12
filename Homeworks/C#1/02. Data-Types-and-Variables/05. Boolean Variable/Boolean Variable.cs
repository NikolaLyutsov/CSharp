//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

using System;

    class Program
    {
        static void Main()
        {
        bool isFemale = false;
        Console.WriteLine("Are you rly a female ? yes or no : ");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            isFemale = true;
            Console.WriteLine(isFemale);
        }
        else if (answer == "no")
        {
            isFemale = false;
            Console.WriteLine(isFemale);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        }
    }

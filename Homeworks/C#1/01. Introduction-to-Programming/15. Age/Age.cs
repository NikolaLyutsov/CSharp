//Write a program that reads your birthday(in the format MM.DD.YYYY) from the console 
//and prints on the console how old you are you now and how old will you be after 10 years.

using System;

    class Age
    {
        static void Main()
        {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine();
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        System.TimeSpan ageNow = currentDate - birthday;
        double youreage = ageNow.TotalDays / 365.25;
        Console.WriteLine((int)youreage);
        Console.WriteLine((int)youreage + 10); 
        }
    }

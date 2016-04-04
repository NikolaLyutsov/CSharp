//A marketing company wants to keep record of its employees.Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender(m or f)
//Personal ID number(e.g. 8306112507)
//Unique employee number(27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names.Print the data at the console.

using System;

    class Program
    {
        static void Main()
        {
        string firstName = "Gosho";
        string lastName = "Goshev";
        byte Age = 22;
        char gender = 'm';
        string PersonalIdNumber = "8306112507";
        long UniqueEmployeeNumber = 275600027569999 ;
        Console.WriteLine("First Name is : "+ firstName);
        Console.WriteLine("Last Name is : "+ lastName);
        Console.WriteLine("Age : "+ Age);
        Console.WriteLine("Gender ? :"+ gender);
        Console.WriteLine("Personal ID Number :"+ PersonalIdNumber);
        Console.WriteLine("Unique Employee Number :"+ UniqueEmployeeNumber);
        }
    }

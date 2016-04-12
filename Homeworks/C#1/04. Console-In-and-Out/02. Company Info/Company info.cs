//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name age and a phone number.
//Write a program that reads the information about a company and its manager 
//and prints it back on the console.

using System;

    class Program
    {
        static void Main()
        {
        string companyname = Console.ReadLine();
        string companyaddress = Console.ReadLine();
        string phonenumber = Console.ReadLine();
        string faxnumber = Console.ReadLine();
        if (faxnumber == "")
        {
            faxnumber = "(no fax)";
        }
        string website = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyname, companyaddress, phonenumber, faxnumber, website, managerFirstName, managerLastName, managerAge, managerPhone);
    }
    }

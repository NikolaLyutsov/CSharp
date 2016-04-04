//A bank account has a holder name(first name, middle name and last name), available amount of money(balance),
//bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the 
//information for a single bank account using the appropriate data types and descriptive names.

using System;

    class Program
    {
        static void Main()
        {
        string firstName = "Gosho";
        string middleName = "Petrov" ;
        string lastName = "Ivanov";
        decimal amountOfMoney = 128.65M ;
        string bankName = "DSK Bulbank OOD";
        string IBAN = "BG324987328974TF";
        long cardNumber1 = 275600027569999;
        long cardNumber2 = 275600027569991;
        long cardNumber3 = 275600027569992;

        Console.WriteLine("First Name is : " + firstName);
        Console.WriteLine("Middle Name is : " + middleName);
        Console.WriteLine("Last Name is : " + lastName);
        Console.WriteLine("Balance money is : " + amountOfMoney);
        Console.WriteLine("Bank name is : " + bankName);
        Console.WriteLine("IBAN : " + IBAN);
        Console.WriteLine("Card number 1 is : " + cardNumber1);
        Console.WriteLine("Card number 2 is : " + cardNumber2);
        Console.WriteLine("Card number 3 is : " + cardNumber3);

    }
    }

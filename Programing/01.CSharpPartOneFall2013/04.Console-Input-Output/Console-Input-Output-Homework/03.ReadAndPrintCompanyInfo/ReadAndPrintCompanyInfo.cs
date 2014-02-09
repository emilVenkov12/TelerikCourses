using System;

class ReadAndPrintCompanyInfo
{
    //03.A company has name, address, phone number, fax number, web site and manager.
    //The manager has first name, last name, age and a phone number. 
    //Write a program that reads the information about a company and its manager and prints them on the console.

    static void Main(string[] args)
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        while (String.IsNullOrEmpty(companyName))
        {
            Console.Write("Enter valid company name (should be not null and non-empty) :");
            companyName = Console.ReadLine();
        }

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        while (String.IsNullOrEmpty(companyAddress))
        {
            Console.Write("Enter valid company address (should be not null and non-empty) :");
            companyAddress = Console.ReadLine();
        }

        //This is basic validation of the phone number. Оf course in real world there should be validation
        //for only numbers and dashes, but for the current example is enough.
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        while (String.IsNullOrEmpty(companyPhoneNumber))
        {
            Console.Write("Enter valid company phone number (should be not null and non-empty) :");
            companyPhoneNumber = Console.ReadLine();
        }

        //Same.
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        while (String.IsNullOrEmpty(companyFaxNumber))
        {
            Console.Write("Enter valid company fax number (should be not null and non-empty) :");
            companyFaxNumber = Console.ReadLine();
        }

        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        while (String.IsNullOrEmpty(managerFirstName))
        {
            Console.Write("Enter valid manager first name (should be not null and non-empty) :");
            managerFirstName = Console.ReadLine();
        }

        Console.Write("Enter manager last name: ");
        string managerLastName = Console.ReadLine();
        while (String.IsNullOrEmpty(managerLastName))
        {
            Console.Write("Enter valid manager last name (should be not null and non-empty) :");
            managerLastName = Console.ReadLine();
        }

        Console.Write("Enter manager age: ");
        byte managerAge = 0;
        while (!byte.TryParse(Console.ReadLine(), out managerAge) || managerAge < 1 || managerAge > 120)
        {
            Console.Write("Enter valid manager age (should be non-negative) :");
        }

        Console.Write("Enter manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        while (String.IsNullOrEmpty(managerPhoneNumber))
        {
            Console.Write("Enter valid company phone number (should be not null and non-empty) :");
            managerPhoneNumber = Console.ReadLine();
        }
        Console.WriteLine("Company info : ");
        Console.WriteLine("\t - name: {0}", companyName);
        Console.WriteLine("\t - address: {0}", companyAddress);
        Console.WriteLine("\t - phone number: {0}", companyPhoneNumber);
        Console.WriteLine("\t - fax number: {0}", companyFaxNumber);
        Console.WriteLine("Manager : {0} {1}, age : {2}", managerFirstName, managerLastName, managerAge);
        Console.WriteLine("\t - phone number: {0}", managerPhoneNumber);
    }
}

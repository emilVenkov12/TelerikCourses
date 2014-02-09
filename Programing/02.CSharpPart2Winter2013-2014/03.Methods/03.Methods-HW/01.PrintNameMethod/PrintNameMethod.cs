namespace _01.PrintNameMethod
{
    using System;
    using System.Linq;

    class PrintNameMethod
    {
        //01.Write a method that asks the user for his name and prints “Hello, <name>” 
        //(for example, “Hello, Peter!”). Write a program to test this method.

        static void Main()
        {
            try
            {
                PrintName(GetName());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static string GetName()
        {
            string inputName = Console.ReadLine();

            if (!inputName.All(char.IsLetter))
            {
                throw new FormatException("The name should contains only letters!");
            }

            return inputName;
        }
    }
}

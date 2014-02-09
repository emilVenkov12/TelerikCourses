using System;

class FindsMaxNumber
{
    //07.Write a program that finds the greatest of given 5 variables.

    static void Main()
    {
        Console.Write("Enter numbers count: ");
        uint numbersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out numbersCount))
        {
            Console.Write("Enter valid numbers count: ");
        }

        double maxNumber = 0, number = 0;
        for (uint i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter {0}-th real number: ", i + 1);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Enter {0}-th real number: ", i + 1);
            }
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine("Max: {0}", maxNumber);
    }
}
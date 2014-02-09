using System;

class Prints1ToNNumbers
{
    //01.Write a program that prints all the numbers from 1 to N.

    static void Main()
    {
        Console.Write("Enter numbers count: ");
        uint numbersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out numbersCount) || numbersCount < 1)
        {
            Console.Write("Enter valid numbers count: ");
        }

        for (uint i = 0; i <= numbersCount; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}

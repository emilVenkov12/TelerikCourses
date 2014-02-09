using System;

class Prints1ToNNumsNotDivBy21
{
    //02.Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

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
            if (i % 21 != 0)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}

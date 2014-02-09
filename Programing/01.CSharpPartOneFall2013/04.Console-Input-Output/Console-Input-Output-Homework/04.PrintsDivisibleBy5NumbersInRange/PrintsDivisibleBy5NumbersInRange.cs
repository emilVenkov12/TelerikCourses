using System;

class PrintsDivisibleBy5NumbersInRange
{
    //04.Write a program that reads two positive integer numbers and prints how many numbers p
    // exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

    static void Main()
    {
        Console.Write("Enter left border of the inteval: ");
        uint leftBorder = 0;
        while (!uint.TryParse(Console.ReadLine(), out leftBorder))
        {
            Console.Write("Enter valid positive number for the left border: ");
        }

        Console.Write("Enter right border of the inteval: ");
        uint rightBorder = 0;
        while (!uint.TryParse(Console.ReadLine(), out rightBorder) || rightBorder < leftBorder)
        {
            Console.Write("Enter valid positive number for the right border (should be bigger than left border): ");
        }

        int numsCounter = 0;
        for (uint num = leftBorder; num <= rightBorder; num++)
        {
            if (num % 5 == 0)
            {
                numsCounter++;
            }
        }

        Console.WriteLine(numsCounter);
    }
}

using System;

class PrintMinAndMaxNumOfNums
{
    //03.Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

    static void Main()
    {
        Console.Write("Enter numbers count: ");
        uint numbersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out numbersCount) || numbersCount < 1)
        {
            Console.Write("Enter valid numbers count: ");
        }

        int maxNum = int.MinValue, minNum = int.MaxValue;

        int currentNum = 0;

        for (uint i = 0; i <= numbersCount; i++)
        {
            Console.Write("Enter number: ");
            while (!int.TryParse(Console.ReadLine(), out currentNum))
            {
                Console.Write("Enter valid number: ");
            }

            if (currentNum > maxNum)
            {
                maxNum = currentNum;
            }

            if (currentNum < minNum)
            {
                minNum = currentNum;
            }
        }

        Console.WriteLine("Max number = {0}, min number = {1}", maxNum, minNum);
    }
}
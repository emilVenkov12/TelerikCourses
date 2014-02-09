using System;

class PrintNumbersSum
{
    //01.Write a program that reads 3 integer numbers from the console and prints their sum.

    static void Main()
    {
        Console.Write("Enter first number : ");
        int firstNum = 0;

        while (!int.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.Write("Enter valid first number: ");
        }

        Console.Write("Enter second number : ");
        int secondNum = 0;

        while (!int.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.Write("Enter valid second number: ");
        }

        Console.Write("Enter third number : ");
        int thirdNum = 0;

        while (!int.TryParse(Console.ReadLine(), out thirdNum))
        {
            Console.Write("Enter valid third number: ");
        }

        long sum = firstNum + secondNum + thirdNum;

        Console.WriteLine("The sum of {0}, {1} and {2} is {3}", firstNum, secondNum, thirdNum, sum);
    }
}
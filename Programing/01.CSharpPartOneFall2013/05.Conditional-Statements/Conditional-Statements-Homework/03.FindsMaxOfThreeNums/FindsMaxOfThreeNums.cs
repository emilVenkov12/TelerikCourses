using System;

class FindsMaxOfThreeNums
{
    //03.Write a program that finds the biggest of three integers using nested if statements.

    static void Main()
    {
        Console.Write("Enter first integer number: ");
        int firstNumber = 0;
        while (!int.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("Enter valid first int number: ");
        }

        Console.Write("Enter second integer number: ");
        int secondNumber = 0;
        while (!int.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.Write("Enter valid second int number: ");
        }

        Console.Write("Enter third integer number: ");
        int thirdNumber = 0;
        while (!int.TryParse(Console.ReadLine(), out thirdNumber))
        {
            Console.Write("Enter valid third int number: ");
        }

        int maxNum = 0;

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                maxNum = firstNumber;
            }
            else
            {
                maxNum = thirdNumber;
            }
        }
        else
        {
            if (secondNumber >= thirdNumber)
            {
                maxNum = secondNumber;
            }
            else
            {
                maxNum = thirdNumber;
            }
        }

        Console.WriteLine("The biggest number is: {0}", maxNum);
    }
}

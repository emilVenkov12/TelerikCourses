using System;

class ExaminesTwoIntVariables
{
    //01.Write an if statement that examines two integer variables and
    //exchanges their values if the first one is greater than the second one.

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

        if (firstNumber > secondNumber)
        {
            int swapHelper = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapHelper;
        }

        Console.WriteLine("Examine results: first nmber = {0}, second number = {1}", firstNumber, secondNumber);
    }
}

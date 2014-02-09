using System;

class SortsThreeRealValuesDesc
{
    //04.Sort 3 real values in descending order using nested if statements.

    static void Main()
    {
        Console.Write("Enter first real number: ");
        double firstNumber = 0;
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("Enter valid first number: ");
        }

        Console.Write("Enter second real number: ");
        double secondNumber = 0;
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.Write("Enter valid second number: ");
        }

        Console.Write("Enter third real number: ");
        double thirdNumber = 0;
        while (!double.TryParse(Console.ReadLine(), out thirdNumber))
        {
            Console.Write("Enter valid third number: ");
        }

        double bigNum = 0, biggerNum = 0, biggestNum = 0;

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                biggestNum = firstNumber;
                if (secondNumber >= thirdNumber)
                {
                    biggerNum = secondNumber;
                    bigNum = thirdNumber;
                }
                else
                {
                    biggerNum = thirdNumber;
                    bigNum = secondNumber;
                }
            }
            else
            {
                biggestNum = thirdNumber;
                if (firstNumber >= thirdNumber)
                {
                    biggerNum = firstNumber;
                    bigNum = thirdNumber;
                }
                else
                {
                    biggerNum = thirdNumber;
                    bigNum = firstNumber;
                }
            }
        }
        else
        {
            if (secondNumber >= thirdNumber)
            {
                biggestNum = secondNumber;
                if (firstNumber >= thirdNumber)
                {
                    biggerNum = firstNumber;
                    bigNum = thirdNumber;
                }
                else
                {
                    biggerNum = thirdNumber;
                    bigNum = firstNumber;
                }
            }
            else
            {
                biggestNum = thirdNumber;
                if (firstNumber >= secondNumber)
                {
                    biggerNum = firstNumber;
                    bigNum = secondNumber;
                }
                else
                {
                    biggerNum = secondNumber;
                    bigNum = firstNumber;
                }
            }
        }

        Console.WriteLine("{0}, {1}, {2}", bigNum, biggerNum, biggestNum);
    }
}

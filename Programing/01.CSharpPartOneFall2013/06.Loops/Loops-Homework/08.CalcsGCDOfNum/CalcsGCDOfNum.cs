using System;

class CalcsGCDOfNum
{
    //08.Write a program that calculates the greatest common divisor
    //(GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

    static void Main()
    {
        Console.Write("Enter first number: ");
        uint firstNum = 0;
        while (!uint.TryParse(Console.ReadLine(), out firstNum) || firstNum == 0)
        {
            Console.Write("Enter valid first number: ");
        }

        Console.Write("Enter second number: ");
        uint secondNum = 0;
        while (!uint.TryParse(Console.ReadLine(), out secondNum) || secondNum == 0)
        {
            Console.Write("Enter valid second number: ");
        }

        ulong gcd = GetCGD(firstNum, secondNum);
        Console.WriteLine("The GCD of {0} and {1} is {2}", firstNum, secondNum, gcd);
    }

    private static ulong GetCGD(uint firstNum, uint secondNum)
    {
        uint helper = 0;
        while (secondNum != 0)
        {
            helper = secondNum;
            secondNum = firstNum % secondNum;
            firstNum = helper;
        }

        return firstNum;
    }
}


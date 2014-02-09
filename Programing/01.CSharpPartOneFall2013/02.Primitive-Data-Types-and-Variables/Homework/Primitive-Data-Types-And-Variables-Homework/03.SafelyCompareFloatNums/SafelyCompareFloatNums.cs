using System;
using System.Threading;

class SafelyCompareFloatNums
{
    //03.Write a program that safely compares floating-point numbers with precision of 0.000001.
    //Examples:(5.3 ; 6.01) --> false;  (5.00000001 ; 5.00000003) --> true

    static void Main()
    {
        
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter first num (use point (.) for separator) : ");
        decimal firstNum = decimal.Parse(Console.ReadLine());

        Console.Write("\nEnter second num (use point (.) for separator) : ");
        decimal secondNum = decimal.Parse(Console.ReadLine());


        decimal precision = 0.000001m;

        decimal diffrence = Math.Abs(firstNum - secondNum);
        bool isEqual = precision >= diffrence;
        Console.Write("\nIs the numbers {0} and {1} equal whit precision: {2:F6}: {3}\n", 
            firstNum, secondNum, precision, isEqual);
   
    }
}


using System;

class ShowsSignOfNumbersProduct
{
    //02.Write a program that shows the sign (+ or -) of the product
    //of three real numbers without calculating it. Use a sequence of if statements.

    static void Main()
    {
        Console.Write("Enter first real number: ");
        double firstNum = 0;
        while (!double.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.Write("Enter valid first number: ");
        }

        Console.Write("Enter first real number: ");
        double secondNum = 0;
        while (!double.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.Write("Enter valid second number: ");
        }

        Console.Write("Enter third real number: ");
        double thirdNum = 0;
        while (!double.TryParse(Console.ReadLine(), out thirdNum))
        {
            Console.Write("Enter valid third number: ");
        }

        int minusSingnsCount = 0;
        if (firstNum < 0)
        {
            minusSingnsCount++;
        }

        if (secondNum < 0)
        {
            minusSingnsCount++;
        }

        if (thirdNum < 0)
        {
            minusSingnsCount++;
        }

        Console.WriteLine("The sign of the product is: {0}", minusSingnsCount % 2 == 0 ? "+" : "-");

        //VARIANT 2
        //Console.Write("Enter number count: ");
        //uint numbersCount = 0;
        //while (!uint.TryParse(Console.ReadLine(), out numbersCount))
        //{
        //    Console.Write("Enter valid numbers count: ");
        //}

       // int minusSingnsCount = 0;
        //double number = 0;
        //for (uint i = 0; i < numbersCount; i++)
        //{
        //    Console.Write("Enter {0}-th real number: ", i + 1);
        //    while (!double.TryParse(Console.ReadLine(), out number))
        //    {
        //        Console.Write("Enter {0}-th real number: ", i + 1);
        //    }
        //    if (number < 0)
        //    {
        //        minusSingnsCount++;
        //    }
        //}

        //Console.WriteLine("The sign of the product is: {0}", minusSingnsCount % 2 == 0 ? "+" : "-");
    }
}

using System;

class PrintMaxNumber
{
    //05.Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

    static void Main()
    {
        Console.Write("Enter first num : ");
        int firstNum = 0;
        while (!int.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.Write("Enter valid first num: ");
        }

        Console.Write("Enter first num : ");
        int secondNum = 0;
        while (!int.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.Write("Enter valid second num: ");
        }

        Console.WriteLine("Max number: {0}", Math.Max(firstNum, secondNum));

        //Console.WriteLine("Max number: {0}", firstNum - ((firstNum - secondNum) & ((firstNum - secondNum) >> 31)));
    }
}

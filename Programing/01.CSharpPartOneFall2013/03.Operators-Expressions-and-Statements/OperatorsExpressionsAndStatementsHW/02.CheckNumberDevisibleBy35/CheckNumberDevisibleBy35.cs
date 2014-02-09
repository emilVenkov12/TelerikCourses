using System;

class CheckNumberDevisibleBy35
{
    //02.Write a boolean expression that checks for given integer 
    //if it can be divided (without remainder) by 7 and 5 in the same time.

    static void Main()
    {
        //Console.Write("Enter integer number: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        int number = 70;

        Console.WriteLine("Is number {0} devisible to 7 and 5 in same time?  {1}.", number,
            number % 7*5 == 0 ? true : false);
    }
}

using System;

class ChecksNumberOddOrEven
{
    //01.Write an expression that checks if given integer is odd or even.

    static void Main()
    {
        //Console.Write("Enter integer number: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        int number = -1;

        Console.WriteLine("The number {0} is {1}.", number,
            number % 2 == 0 ? "even" : "odd");
    }
}

using System;

class CheckThirdDigitOfNumber
{
    //04.Write an expression that checks for given integer 
    //if its third digit (right-to-left) is 7. E. g. 1732 --> true.

    static void Main(string[] args)
    {
        //Console.Write("Enter integer number: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        int number = 1732;

        int thirdDigit = (number / 100) % 10;

        Console.WriteLine("Is third digit of {0} seven ? {1}",
            number, thirdDigit == 7 ? true : false);
    }
}

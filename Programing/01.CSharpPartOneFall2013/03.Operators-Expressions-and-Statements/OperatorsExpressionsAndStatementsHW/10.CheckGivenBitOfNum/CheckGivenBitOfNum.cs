using System;

class CheckGivenBitOfNum
{
    //10.Write a boolean expression that returns if the bit at position
    //p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 --> false.

    static void Main()
    {
        //Console.Write("Enter integer nummber: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        //Console.Write("Enter position (must be positive and less than 32): ");
        //int position = 0;
        //while (!int.TryParse(Console.ReadLine(), out number) && position < 0 && position > 31)
        //{
        //    Console.Write("Enter a valid position(must be postive)!: ");
        //}

        int number = 5,
            position = 1;
        int mask = 1 << position;

        bool isBitEqualTo1 = (number & mask) != 0;

        Console.WriteLine("Is bit at possition {0} equal to 1 ? {1}", position, isBitEqualTo1);
    }
}

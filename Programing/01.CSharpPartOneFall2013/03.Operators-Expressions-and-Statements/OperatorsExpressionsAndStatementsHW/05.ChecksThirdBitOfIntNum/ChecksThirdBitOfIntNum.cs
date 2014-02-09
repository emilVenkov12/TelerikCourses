using System;

class ChecksThirdBitOfIntNum
{
    //05.Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

    static void Main()
    {
        //Console.Write("Enter integer number: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        int number = 7;
        int mask = 1 << 3;

        Console.WriteLine("Third bit of {0} is {1}.", number, (number & mask) != 0 ? 1 : 0);
    }
}


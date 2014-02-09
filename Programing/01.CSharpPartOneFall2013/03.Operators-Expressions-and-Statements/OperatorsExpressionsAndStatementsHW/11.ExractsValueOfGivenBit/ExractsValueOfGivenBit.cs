using System;

class ExractsValueOfGivenBit
{
    //11.Write an expression that extracts from a given integer i
    //the value of a given bit number b. Example: i=5; b=2 --> value=1.

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
            possiton = 2;
        int mask = 1 << possiton;
        int value = (number & mask) != 0 ? 1 : 0;

        Console.WriteLine("The value of the bit on position {0} is {1}", possiton, value);
    }
}


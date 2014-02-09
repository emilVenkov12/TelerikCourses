using System;

class ExchangeBits3_4_5With24_25_26
{
    //13.Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

    static void Main()
    {
        //Console.Write("Enter integer nummber: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}
        int number = 8;

        int mask = 1 << 3;
        int bit3Value = (number & mask) != 0 ? 1 : 0;

        mask = 1 << 4;
        int bit4Value = (number & mask) != 0 ? 1 : 0;

        mask = 1 << 5;
        int bit5Value = (number & mask) != 0 ? 1 : 0;

        mask = 1 << 24;
        int bit24Value = (number & mask) != 0 ? 1 : 0;

        mask = 1 << 25;
        int bit25Value = (number & mask) != 0 ? 1 : 0;

        mask = 1 << 26;
        int bit26Value = (number & mask) != 0 ? 1 : 0;

        SetBit(ref number, bit3Value, 24);
        SetBit(ref number, bit4Value, 25);
        SetBit(ref number, bit5Value, 26);

        SetBit(ref number, bit24Value, 3);
        SetBit(ref number, bit25Value, 4);
        SetBit(ref number, bit26Value, 5);

        Console.WriteLine("The new number is {0}", number);
        
    }

    private static void SetBit(ref int number, int value, int position)
    {
        int mask = 1 << position;
        if (value == 1)
        {
            number = (number | mask);
        }
        else
        {
            number = (number & (~mask));
        }
    }
}


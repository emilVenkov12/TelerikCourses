using System;

class ExchangeBits
{
    static void Main(string[] args)
    {
        #region Manual Input

        //Console.Write("Enter integer nummber: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        //Console.Write("Enter k: ");
        //int k = 0;
        //while (!int.TryParse(Console.ReadLine(), out k) || k > 31)
        //{
        //    Console.Write("Enter a valid k(should be less than 32)!: ");
        //}

        //Console.Write("Enter p: ");
        //int p = 0;
        //while (!int.TryParse(Console.ReadLine(), out p) || p + k-1 > 31)
        //{
        //    Console.Write("Enter a valid k((p + k-1) should be less than 32)!: ");
        //}

        //Console.Write("Enter q: ");
        //int q = 0;
        //while (!int.TryParse(Console.ReadLine(), out q) || q + k-1 > 31)
        //{
        //    Console.Write("Enter a valid k((q + k-1) should be less than 32)!: ");
        //}

        #endregion

        int number = 15;
        int k = 4,
            p = 0,
            q = 4;

        for (int i = 0; i < k; i++)
        {
            SwapBits(ref number, p + i, q + i);
        }

        Console.WriteLine("Result after swaping: {0}", number);

    }

    private static void SwapBits(ref int number, int firstBitPos, int secondBitPos)
    {
        int firstBitValue = GetBitValue(number, firstBitPos);
        int secondBitValue = GetBitValue(number, secondBitPos);

        SetBit(ref number, firstBitValue, secondBitPos);
        SetBit(ref number, secondBitValue, firstBitPos);
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

    private static int GetBitValue(int number, int pos)
    {
        int mask = 1 << pos;
        return (number & mask) != 0 ? 1 : 0;
    }
}
namespace _08.BinReprOfShortNum
{
    using System;

    class BinReprOfShortNum
    {
        //08.Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

        static void Main()
        {
            short number = -20;
            int bitsCount = 16;
            string binNumber = GetBits(number, bitsCount);

            Console.WriteLine("{0} = {1}", number, binNumber);
        }

        private static string GetBits(short number, int bitCount)
        {
            string result = String.Empty;
            short mask = 1;

            for (int i = bitCount - 1; i >= 0; i--)
            {
                result += (number & (mask << i)) > 0 ? "1" : "0";
            }

            return result;
        }
    }
}

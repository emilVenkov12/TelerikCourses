namespace _02.ConvertBinToDec
{
    using System;

    class ConvertBinToDec
    {
        //02.Write a program to convert binary numbers to their decimal representation.

        static void Main()
        {
            string binNumber = "10";

            int decNumber = ConvertFromBinToDec(binNumber);

            Console.WriteLine("{0} -> {1}", binNumber, decNumber);
        }

        private static int ConvertFromBinToDec(string binNumber)
        {
            int result = 0;

            for (int i = 0; i < binNumber.Length; i++)
            {
                result += (binNumber[i] - '0') * (int)IntegerPower(2, binNumber.Length - 1 - i);
            }

            return result;
        }

        static long IntegerPower(int number, int power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}

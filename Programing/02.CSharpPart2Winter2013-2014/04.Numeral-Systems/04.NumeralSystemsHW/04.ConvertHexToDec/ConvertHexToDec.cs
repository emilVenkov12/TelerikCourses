namespace _04.ConvertHexToDec
{
    using System;

    class ConvertHexToDec
    {
        //04.Write a program to convert hexadecimal numbers to their decimal representation.

        static void Main()
        {
            string hexNumber = "A";

            int decNumber = ConvertFromHexToDec(hexNumber);
            Console.WriteLine("{0} -> {1}", hexNumber, decNumber);
        }

        private static int ConvertFromHexToDec(string hexNumber)
        {
            int result = 0;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                result += (hexNumber[i] <= '9' ? (int)(hexNumber[i] - '0') : (int)(hexNumber[i] - 'A') + 10) * 
                    (int)IntegerPower(16, hexNumber.Length - 1 - i);
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

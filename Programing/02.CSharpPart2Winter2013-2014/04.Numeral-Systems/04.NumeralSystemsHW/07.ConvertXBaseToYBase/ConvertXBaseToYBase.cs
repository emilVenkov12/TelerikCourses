namespace _07.ConvertXBaseToYBase
{
    using System;

    class ConvertXBaseToYBase
    {
        //07.Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

        static void Main()
        {
            int xBase = 10, yBase = 2;
            string xBasedNumber = "10";

            string yBasedNumber = ConvertFromXBaseToYBase(xBase, yBase, xBasedNumber);

            Console.WriteLine("{0} -> {1}", xBasedNumber, yBasedNumber);
        }

        private static string ConvertFromXBaseToYBase(int fromBase, int toBase, string number)
        {
            int decNumber = 0;

            if (fromBase == 10)
            {
                decNumber = int.Parse(number);
            }
            else
            {
                decNumber = ConvertToDec(number, fromBase);
            }

            string toBaseNumber = decNumber.ToString();

            if (toBase != 10)
            {
                toBaseNumber = ConvertFromDecTo(toBase, decNumber);
            }

            return toBaseNumber;
        }

        private static string ConvertFromDecTo(int toBase, int number)
        {
            string result = String.Empty;

            while (number > 0)
            {
                int remainder = (number % toBase);
                result = (remainder > 9 ? (char)('A' + (remainder - 10)) : (char)('0' + remainder)) + result;
                number /= toBase;
            }

            return result;
        }

        private static int ConvertToDec(string number, int fromBase)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                result += (number[i] <= '9' ? (int)(number[i] - '0') : (int)(number[i] - 'A') + 10) *
                    (int)IntegerPower(fromBase, number.Length - 1 - i);
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

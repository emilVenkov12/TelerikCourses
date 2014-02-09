namespace _03.ConvertDecToHex
{
    using System;

    class ConvertDecToHex
    {
        //03.Write a program to convert decimal numbers to their hexadecimal representation.

        static void Main()
        {
            int decNumber = 16;

            string hexNumber = ConvertFromDecToHex(decNumber);
            Console.WriteLine("{0} -> {1}", decNumber, hexNumber);
        }

        private static string ConvertFromDecToHex(int decNumber)
        {
            string result = String.Empty;

            while (decNumber > 0)
            {
                int remainder = (decNumber % 16);
                result = (remainder > 9 ? (char)('A' + (remainder - 10)) : (char)('0' + remainder)) + result;
                decNumber /= 16;
            }
            return result;
        }
    }
}

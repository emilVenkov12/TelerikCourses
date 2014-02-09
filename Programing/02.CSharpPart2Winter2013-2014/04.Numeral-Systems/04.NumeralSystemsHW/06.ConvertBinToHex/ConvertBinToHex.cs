namespace _06.ConvertBinToHex
{
    using System;
    using System.Collections.Generic;

    class ConvertBinToHex
    {
        //06.Write a program to convert binary numbers to hexadecimal numbers (directly).

        static void Main(string[] args)
        {
            string binNumber = "00s01";

            string hexNumber = ConvertFromBinToHex(binNumber);

            Console.WriteLine("{0} -> {1}", binNumber, hexNumber);
        }

        private static string ConvertFromBinToHex(string binNumber)
        {
            string result = String.Empty;

            Dictionary<string, string> binNumbersHex = new Dictionary<string, string>();

            binNumbersHex.Add("0000", "0");
            binNumbersHex.Add("0001", "1");
            binNumbersHex.Add("0010", "2");
            binNumbersHex.Add("0011", "3");
            binNumbersHex.Add("0100", "4");
            binNumbersHex.Add("0101", "5");
            binNumbersHex.Add("0110", "6");
            binNumbersHex.Add("0111", "7");
            binNumbersHex.Add("1000", "8");
            binNumbersHex.Add("1001", "9");
            binNumbersHex.Add("1010", "A");
            binNumbersHex.Add("1011", "B");
            binNumbersHex.Add("1100", "C");
            binNumbersHex.Add("1101", "D");
            binNumbersHex.Add("1110", "E");
            binNumbersHex.Add("1111", "F");

            while (binNumber.Length % 4 != 0)
            {
                binNumber = "0" + binNumber;
            }

            for (int i = 0; i < binNumber.Length; i += 4)
            {
                result += binNumbersHex[binNumber.Substring(i, 4)];
            }

            return result;
        }
    }
}

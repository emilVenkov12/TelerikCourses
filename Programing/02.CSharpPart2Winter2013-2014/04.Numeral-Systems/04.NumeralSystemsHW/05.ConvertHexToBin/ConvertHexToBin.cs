namespace _05.ConvertHexToBin
{
    using System;

    class ConvertHexToBin
    {
        //05.Write a program to convert hexadecimal numbers to binary numbers (directly).

        static void Main()
        {
            string hexNumber = "F";

            string binNumber = ConvertFromHexToBin(hexNumber);

            Console.WriteLine("{0} -> {1}", hexNumber, binNumber);
        }

        private static string ConvertFromHexToBin(string hexNumber)
        {
            string[] hexNumberToBin = new string[] { "0000", "0001", "0010", "0011", "0100", "0101",
                "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"};

            string result = String.Empty;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                result +=hexNumber[i] > '9' ? hexNumberToBin[(int)(hexNumber[i] - 'A') + 10] : hexNumberToBin[(int)(hexNumber[i] - '0')];
            }

            return result;
        }
    }
}

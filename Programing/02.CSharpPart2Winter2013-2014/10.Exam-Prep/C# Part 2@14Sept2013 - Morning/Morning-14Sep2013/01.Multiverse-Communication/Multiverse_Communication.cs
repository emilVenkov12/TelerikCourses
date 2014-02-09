namespace _01.Multiverse_Communication
{
    using System;
    using System.Text;
    using System.Numerics;
    using System.Collections.Generic;

    class Multiverse_Communication
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, char> dict = new Dictionary<string, char>() 
            {
                {"CHU", '0'}, {"TEL", '1'}, {"OFT", '2'},
                {"IVA", '3'}, {"EMY", '4'}, {"VNB", '5'},
                {"POQ", '6'}, {"ERI", '7'}, {"CAD", '8'}, 
                {"K-A", '9'}, {"IIA", 'A'}, {"YLO", 'B'},
                {"PLA", 'C'}

            };
            StringBuilder number = new StringBuilder();

            for (int i = 0; i < input.Length; i+= 3)
            {
                string num = input.Substring(i, 3);
                number.Append(dict[num]);
            }

            Console.WriteLine(ConvertToDec(number.ToString(), 13));
        }

        private static BigInteger ConvertToDec(string number, int fromBase)
        {
            BigInteger result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                result += (number[i] <= '9' ? (int)(number[i] - '0') : (int)(number[i] - 'A') + 10) *
                    IntegerPower(fromBase, number.Length - 1 - i);
            }

            return result;
        }

        static BigInteger IntegerPower(int number, int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}

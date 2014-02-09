namespace _01.DurankulakNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    class DurankulakNumbers
    {
        static void Main()
        {
            string number = Console.ReadLine();
            
            //Console.WriteLine(GetDigitValue("aA"));

            BigInteger decNum = ConvertToDec(number);
            Console.WriteLine(decNum);
        }

        private static BigInteger ConvertToDec(string number)
        {
            BigInteger result = 0;

            var digits = GetDigits(number);

            for (int i = 0; i < digits.Length; i++)
            {
                result += GetDigitValue(digits[i]) * Pow(168, digits.Length - i - 1);
            }

            return result;
        }

        private static string[] GetDigits(string number)
        {
            List<string> digits = new List<string>();

            for (int i = 0; i < number.Length; i++)
            {
                StringBuilder digit = new StringBuilder();
                digit.Append(number[i] + "");

                if (char.IsLower(number[i]))
                {
                    digit.Append(number[++i] + "");
                }

                digits.Add(digit.ToString());                
            }

            return digits.ToArray();
        }

        static int GetDigitValue(string digit)
        {
            int result = 0;

            for (int i = 0; i < digit.Length; i++)
            {
                if (char.IsLower(digit[i]))
                {
                    result += (int)(digit[i] - 'a' + 1) * 26;
                }
                else
                {
                    result += (int)digit[i] - 65;
                }
            }

            return result;
        }

        static BigInteger Pow(int number, int power)
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

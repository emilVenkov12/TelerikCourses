namespace _01.KaspichanNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;
    using System.Linq;

    class KaspichanNumbers
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            //Console.WriteLine(GetDigitValue("aA"));

            //string newNum = ConvertFromDecTo(number, 256);

            Console.WriteLine(ConvertFromDecTo(number, 256));
        }

        private static string ConvertFromDecTo(BigInteger number, int toBase)
        {
            string digits = String.Empty;

            if (number == 0)
            {
                return 'A' + "";
            }
            while (number > 0)
            {
                digits = ConvertTo26(number % toBase) + digits;
                number /= toBase;
            }

            return digits;
        }

        static string ConvertTo26(BigInteger num)
        {
            int firstCharCode = 0,
                secondCharCode = 0;
            if (num < 26)
            {
                return "" + (char)(65 + num);
            }

            firstCharCode = (int)num / 26;
            secondCharCode = (int)num - (firstCharCode * 26);

            return ""+ (char)('a' + firstCharCode - 1) + (char)('A' + secondCharCode);
        }
    }
}

namespace _01.ConvertDecToBin
{
    using System;

    class ConvertDecToBin
    {
        //01.Write a program to convert decimal numbers to their binary representation.

        static void Main()
        {
            int number = 10;
            //Works only for positive numbers!
            string binNumber = ConvertFromDecToBin(number);
            Console.WriteLine("{0} -> {1}", number, binNumber);
        }

        private static string ConvertFromDecToBin(int number)
        {
            string result = String.Empty;

            while (number > 0)
            {
                result = (number % 2) + result;
                number /= 2;
            }

            return result;
        }
    }
}

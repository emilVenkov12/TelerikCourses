namespace _09.GetBitsOfFloatNum
{
    using System;
    using System.Linq;

    class GetBitsOfFloatNum
    {
        //09.* Write a program that shows the internal binary representation of 
        //given 32-bit signed floating-point number in IEEE 754 format (the C# type float). 
        //Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

        static void Main()
        {
            float number = -27.25f;

            int sign = number > 0 ? 0 : 1;
            byte[] bytes = BitConverter.GetBytes(number); 

            string bits = GetBits(bytes);

            string exponent = GetExponent(bits);
            string mantisa = GetMantisa(bits);

            Console.WriteLine("{0} -> sign = {1}, exponent = {2}, mantisa = {3}",
                number, sign, exponent, mantisa);
        }

        private static string GetMantisa(string bits)
        {
            string result = String.Empty;

            for (int i = 9; i < bits.Length; i++)
            {
                result += bits[i] + "";
            }

            return result;
        }

        private static string GetExponent(string bits)
        {
            string result = String.Empty;

            for (int i = 1; i <= 8; i++)
            {
                result += bits[i] + "";
            }

            return result;
        }

        static string GetBits(byte[] bytes)
        {
            string result = String.Empty;

            for (int i = bytes.Length - 1; i >= 0; i--)
            {
                result += ConvertToBin(bytes[i]).PadLeft(8, '0');
            }

            return result;
        }

        private static string ConvertToBin(byte number)
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

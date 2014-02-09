namespace _07.ReversNumberDigits
{
    using System;

    class ReversNumberDigits
    {
        //07.Write a method that reverses the digits of given decimal number. Example: 256  652

        static void Main()
        {
            #region Manual Input

            //Console.Write("Enter number: ");
            //int number = 0;
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Enter valid number: ");
            //}

            #endregion

            int number = 256;

            Console.WriteLine("Result: {0} -> {1}", number, ReversDigirs(number));

        }

        static int ReversDigirs(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }
    }
}

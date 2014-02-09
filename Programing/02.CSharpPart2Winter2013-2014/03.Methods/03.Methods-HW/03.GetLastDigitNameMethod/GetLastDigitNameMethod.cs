namespace _03.GetLastDigitNameMethod
{
    using System;

    class GetLastDigitNameMethod
    {
        //03.Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

        static void Main()
        {
            #region Manual Input

            //int number = 0;
            //Console.Write("Enter number: ");

            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Enter valid number: ");
            //}

            #endregion

            int number = -12349;
            Console.WriteLine("Last digit of {0} is {1}.", number, GetLastDigitName(number));
        }

        static string GetLastDigitName(int number)
        {
            int digit = Math.Abs(number % 10);

            string[] digitsNames = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return digitsNames[digit];
        }
    }
}

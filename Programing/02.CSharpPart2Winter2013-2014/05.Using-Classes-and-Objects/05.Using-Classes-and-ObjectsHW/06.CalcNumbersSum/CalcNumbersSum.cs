namespace _06.CalcNumbersSum
{
    using System;
    using System.Linq;

    class CalcNumbersSum
    {
        //06.You are given a sequence of positive integer values written into a string, 
        //separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
        //string = "43 68 9 23 318"  result = 461

        static void Main()
        {
            string input = "43 68 9 23 318";

            long sum = CalcSum(input);
            Console.WriteLine("The sum of the numbers is {0}", sum);
        }

        private static long CalcSum(string input)
        {
            string[] numbers = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long sum = numbers.Sum(x => long.Parse(x));

            return sum;
        }
    }
}

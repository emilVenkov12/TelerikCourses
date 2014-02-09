namespace _02.Read10SpecNumbers
{
    using System;

    class Read10SpecNumbers
    {
        //02.Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
        //If an invalid number or non-number text is entered, the method should throw an exception. 
        //Using this method write a program that enters 10 numbers:
		//	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

        static void Main()
        {
            double min = 1, max = 100,
                numbersCount = 10;
            try
            {
                for (int i = 0; i < numbersCount; i++)
                {
                    min = ReadNumber(min, max);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The entered number isn't in correct range( 1 < a1 < ... < a10 < 100) !!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You should enter a number!!!");
            }

        }

        static double ReadNumber(double start, double end)
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());
            if ((number < start) || (number > end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;

        }
    }
}

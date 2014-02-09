namespace _11.PrintsNumberDiffrentWays
{
    using System;

    class PrintsNumberDiffrentWays
    {
        //11.Write a program that reads a number and prints it as a decimal number, 
        //hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

        static void Main()
        {
            int number = 26;
            Console.WriteLine("As decimal number: {0,15:F}", number);
            Console.WriteLine("As hexadecimal number: {0,15:X}", number);
            Console.WriteLine("As percentage number: {0,15:P}", number);
            Console.WriteLine("As scientific notation number: {0,15:E}", number);
        }
    }
}

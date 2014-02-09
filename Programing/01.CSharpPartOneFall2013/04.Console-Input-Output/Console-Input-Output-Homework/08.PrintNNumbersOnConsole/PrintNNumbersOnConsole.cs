using System;
using System.Text;

class PrintNNumbersOnConsole
{
    static void Main()
    {
        Console.Write("Enter numbers count: ");
        uint numbersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out numbersCount))
        {
            Console.Write("Enter valid numbers count: ");
        }

        double number = 0;
        StringBuilder output = new StringBuilder();

        for (uint i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter next number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Enter next valid number: ");
            }

            output.AppendLine(number + "");
        }

        Console.WriteLine("The entered numbrs are: \n{0}", output.ToString());
    }
}


using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter numbers count: ");
        uint numbersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out numbersCount))
        {
            Console.Write("Enter valid numbers count: ");
        }

        double number = 0, sum = 0;
        for (uint i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter next number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Enter next valid number: ");
            }
            sum += number;
        }
        Console.WriteLine("The sum of entered numbers is: {0}", sum);
    }
}

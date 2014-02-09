using System;
using System.Text;

class NumberToText
{
    //11.* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
    static void Main()
    {
        Console.Write("Enter number [0..999]: ");
        int number = 0;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999)
        {
            Console.Clear();
            Console.Write("Enter number in range [0..999]: ");
        }

        Console.WriteLine(Numbers0To999ToText(number));
    }

    static string Numbers0To999ToText(int number)
    {
        string[] numbers0To19 = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] numbers20To90 = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        int hundreds = number / 100;
        number %= 100;
        StringBuilder result = new StringBuilder();

        if (hundreds > 0)
        {
            result.Append(numbers0To19[hundreds] + " hundred" + (number > 0 ? " and " : " "));
        }

        if (number > 19)
        {
            int tens = number / 10;
            number %= 10;
            result.Append(numbers20To90[tens - 2] + (number > 0 ? "-" : ""));
        }

        if (number < 20 && number > 0)
        {
            result.Append(numbers0To19[number]);
        }
        if (number == 0 && result.Length == 0)
        {
            result.Append(numbers0To19[number]);
        }

        return result.ToString();
    }
}

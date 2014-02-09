using System;

class DiffrentInputType
{
    //08.Write a program that, depending on the user's choice inputs int, double or string variable. 
    //If the variable is integer or double, increases it with 1. 
    //If the variable is string, appends "*" at its end. 
    //The program must show the value of that variable as a console output. Use switch statement.

    static void Main(string[] args)
    {
        Console.Write("Enter int, double or string value: ");
        string input = Console.ReadLine();
        double number = 0;
        if (double.TryParse(input, out number))
        {
            Console.WriteLine("{0:F}",number + 1d);
        }
        else 
        {
            Console.WriteLine(input + "*");
        }
    }
}


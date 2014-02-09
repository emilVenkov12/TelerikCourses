using System;

class CalcsTrapezoidArea
{
    //08.Write an expression that calculates trapezoid's area by given sides a and b and height h.

    static void Main()
    {
        //Console.Write("Enter side a: ");
        //double sideA = 0;
        //while (!double.TryParse(Console.ReadLine(), out sideA))
        //{
        //    Console.Write("Enter a valid side a!: ");
        //}

        //Console.Write("Enter side b: ");
        //double sideB = 0;
        //while (!double.TryParse(Console.ReadLine(), out sideB))
        //{
        //    Console.Write("Enter a valid side b!: ");
        //}

        //Console.Write("Enter height h: ");
        //double height = 0;
        //while (!double.TryParse(Console.ReadLine(), out height))
        //{
        //    Console.Write("Enter a valid height h!: ");
        //}

        double sideA = 6.7,
            sideB = 7.8,
            height = 4.4;
        double area = ((sideA + sideB) / 2) * height;

        Console.WriteLine("The area of trapezoid with sideA = {0}\n"+
            "\tsideB = {1} and height h = {2} is {3}.", sideA, sideB, height, area);
    }
}

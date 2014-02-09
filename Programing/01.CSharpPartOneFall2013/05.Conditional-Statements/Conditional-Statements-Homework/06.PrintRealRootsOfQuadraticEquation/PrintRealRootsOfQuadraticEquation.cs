using System;

class PrintRealRootsOfQuadraticEquation
{
    //06.Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
    //Note that quadratic equations may have 0, 1 or 2 real roots.

    static void Main()
    {
        Console.Write("Enter coef. a: ");
        double a = 0.0;
        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
            Console.Write("Enter valid a coef. (should be non-negative and greater than zero): ");
        }

        Console.Write("Enter coef. b: ");
        double b = 0.0;
        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
        {
            Console.Write("Enter valid b coef. (should be non-negative and greater than zero): ");
        }

        Console.Write("Enter coef. c: ");
        double c = 0.0;
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Enter valid c coef.: ");
        }

        double D = (b * b) - 4 * a * c;

        if (D < 0)
        {
            Console.WriteLine("The equation don't have real nodes.");
        }
        else
        {
            if (D == 0)
            {
                double node = -b / (2 * a);
                Console.WriteLine("The equation have one doble node: {0}.", node);
            }
            else
            {
                double firtsNode = (-b + Math.Sqrt(D)) / (2 * a);
                double secondNode = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("The equation have two nodes: first node: {0}, second node {1}", firtsNode, secondNode);
            }
        }
    }
}
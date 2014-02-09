using System;

class CalcAndPrintCircleAreaAndPerimeter
{
    //02.Write a program that reads the radius r of a circle and prints its perimeter and area.

    static void Main()
    {
        Console.Write("Enter circle radius: ");
        double circleRadius = 0.0;

        while (!double.TryParse(Console.ReadLine(), out circleRadius) || circleRadius  <= 0)
        {
            Console.Write("Enter valid circle radius (should be non-negarive) : ");
        }

        double perimeter = 2 * Math.PI * circleRadius;
        double area = Math.PI * circleRadius * circleRadius;

        Console.WriteLine("Circle with radius {0} have perimeter: {1} and area: {2}.", circleRadius, perimeter, area);
    }
}
using System;

class IsPointWithinCircle
{
    //06.Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

    static void Main()
    {
        //Console.Write("Enter point X: ");
        //double pointX = 0;
        //while (!double.TryParse(Console.ReadLine(), out pointX))
        //{
        //    Console.Write("Enter a valid X coordinate!: ");
        //}

        //Console.Write("Enter point Y: ");
        //double pointY = 0;
        //while (!double.TryParse(Console.ReadLine(), out pointY))
        //{
        //    Console.Write("Enter a valid Y coordinate!: ");
        //}

        double pointX = 0.8,
            pointY = 0.8;
        double circleCenterX = 0,
            circleCenterY = 0,
            circleRadius = 5;

        bool isWithinCircle = (Math.Pow(pointX - circleCenterX, 2) + Math.Pow(pointY - circleCenterY, 2)) < circleRadius;

        Console.WriteLine("Is the point({0}, {1}) in circle(O,5)? {2}", pointX, pointY, isWithinCircle);


    }
}

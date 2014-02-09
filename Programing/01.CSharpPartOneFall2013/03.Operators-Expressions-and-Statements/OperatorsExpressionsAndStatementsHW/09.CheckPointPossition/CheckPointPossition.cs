using System;

class CheckPointPossition
{
    //09.Write an expression that checks for given point (x, y) if it is 
    //within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

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

        double pointX = 1.1,
            pointY = -1.1;

        double circleCenterX = 1,
            circleCenterY = 1,
            circleRadius = 3;
        double rectHeight = 2,
            rectWidth = 6,
            rectTop = 1,
            rectLeft = -1;

        bool isWithinCircle = (Math.Pow(pointX - circleCenterX, 2) + Math.Pow(pointY - circleCenterY, 2)) < circleRadius;

        bool isOutOfRect = (pointX < rectTop || pointY > rectLeft) &&
            (pointX > rectTop + rectWidth || pointY < rectLeft + rectHeight);

        Console.WriteLine("Is point({0}, {1}) within circle K((1,1),3)\n\t"+
            " and out of rect R(top = 1, left = -1, width = 6, height =2) ? {2}", pointX, pointY, isWithinCircle && isOutOfRect);

    }
}

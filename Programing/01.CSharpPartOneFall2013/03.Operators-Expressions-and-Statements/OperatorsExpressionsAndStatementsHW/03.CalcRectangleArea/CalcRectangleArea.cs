using System;

class CalcRectangleArea
{
    //03.Write an expression that calculates rectangle’s area by given width and height.

    static void Main()
    {
        //Console.Write("Enter rectangle height: ");
        //double height = 0;
        //while (!double.TryParse(Console.ReadLine(), out height))
        //{
        //    Console.Write("Enter a valid height!: ");
        //}

        //Console.Write("Enter rectangle width: ");
        //double width = 0;
        //while (!double.TryParse(Console.ReadLine(), out width))
        //{
        //    Console.Write("Enter a valid width!: ");
        //}

        double width = 1.2, 
            height = 2.2;
        double area = width * height;

        Console.WriteLine("Rectangle with height: {0} and width: {1} have area : {2} ",
            height, width, area);
    }
}
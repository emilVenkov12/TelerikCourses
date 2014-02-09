namespace _04.CalcSurfaceOfTriangle
{
    using System;

    class CalcSurfaceOfTriangle
    {
        //04.Write methods that calculate the surface of a triangle by given:
        //Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

        static void Main()
        {
            double sideA = 3,
                sideB = 4,
                sideC = 5;
            double altitude = 4;
            double angle = 90;
            
            Console.WriteLine("Surface with side and altitude: {0}", 
                CalcTriangleSurfaceWithAltitude(sideA, altitude));
            Console.WriteLine("Surface with 3 sides: {0}", 
                CalcTriangleSurfaceWith3Sides(sideA, sideB, sideC));
            Console.WriteLine("Surface with 2 sides and angle between them: {0}", 
                CalcTriangleSurfaceWith2SideAndAngle(sideA, sideB, angle));
        }

        static double CalcTriangleSurfaceWithAltitude(double side, double altitude)
        {
            double surface = (side * altitude) / 2;

            return surface;
        }

        static double CalcTriangleSurfaceWith3Sides(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;

            double surface = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return surface;
        }

        static double CalcTriangleSurfaceWith2SideAndAngle(double sideA, double sideB, double angle)
        {
            double angleInRadians = Math.PI * angle / 180;

            double surface = (sideA * sideB * Math.Sin(angleInRadians)) / 2;

            return surface;
        }
    }

}

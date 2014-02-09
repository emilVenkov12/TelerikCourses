﻿namespace _01._04.GeometryUtilsTest
{
    using System;
    using GeometryUtils;

    class GeometryUtilsTest
    {
        /*
         1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
         Implement the ToString() to enable printing a 3D point.
         2. Add a private static read-only field to hold the start of the coordinate system
          – the point O{0, 0, 0}. Add a static property to return the point O.
         3. Write a static class with a static method to calculate the distance between two points in the 3D space.
         4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with
         static methods to save and load paths from a text file. Use a file format of your choice.
         */
        static void Main()
        {
            Path path = new Path(Point3D.ZeroPoint);
            path.Add(new Point3D(1, 1, 1));
            path.Add(new Point3D(2, 2, 2));
            Path secPath = PathStorage.LoadPoints(@"../../textFiles\inputFile.txt");
            Console.WriteLine(secPath.ToString());

            secPath.AddRange(path);
            Console.WriteLine();
            Console.WriteLine(secPath.ToString());

            PathStorage.SavePointsToFile(secPath, @"../../textFiles\outputFile.txt");


        }
    }
}

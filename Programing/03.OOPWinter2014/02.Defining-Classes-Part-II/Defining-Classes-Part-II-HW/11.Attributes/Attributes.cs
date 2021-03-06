﻿namespace _11.Attributes
{
    using System;

    [Version(2, 11)]
    class Attributes
    {
        //11. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations 
        //and methods and holds a version in the format major.minor (e.g. 2.11). 
        //Apply the version attribute to a sample class and display its version at runtime.

        static void Main()
        {
            var attrs = typeof(Attributes).GetCustomAttributes(false);
            Console.WriteLine("Version: ({0})", attrs[0].ToString());

        }
    }
}

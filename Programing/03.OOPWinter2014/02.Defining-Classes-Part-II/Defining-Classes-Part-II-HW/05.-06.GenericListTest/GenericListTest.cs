﻿namespace _05._06.GenericListTest
{
    using System;
    using System.Collections.Generic;

    class GenericListTest
    {
        //5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
        //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
        //Implement methods for adding element, accessing element by index, removing element by index, 
        //inserting element at given position, clearing the list, finding element by its value and ToString(). 
        //Check all input parameters to avoid accessing elements at invalid positions.
        //6. Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        //7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
        //You may need to add a generic constraints for the type T

        static void Main()
        {
            GenericList<int> gl = new GenericList<int>(4);
            gl.AddRange(2, 3, 4, 5, 6);
            
            gl.RemoveAt(0);

            Console.WriteLine(gl.ToString());
            Console.WriteLine();
            gl.InsertAt(3, -1);

            Console.WriteLine(gl.ToString());
            Console.WriteLine(gl.Min());
            Console.WriteLine(gl.Max());
        }
    }
}

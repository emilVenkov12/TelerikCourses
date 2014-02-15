namespace _02.IEnumerableExtMethods
{
    using System;
    using System.Collections.Generic;

    class IEnumerableExtMethods
    {
        //02.Implement a set of extension methods for IEnumerable<T> 
        //that implement the following group functions: sum, product, min, max, average.

        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(2);
            list.Add(3);
            list.Add(-1);

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Avarage());
        }
    }
}

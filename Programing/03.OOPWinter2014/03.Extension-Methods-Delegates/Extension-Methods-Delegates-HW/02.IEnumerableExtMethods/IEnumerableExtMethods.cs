namespace _02.IEnumerableExtMethods
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class IEnumerableExtMethods
    {
        static void Main()
        {
            List<string> list = new List<string>();

            Console.WriteLine(list.Sum());
        }
    }
}

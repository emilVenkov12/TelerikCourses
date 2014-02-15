namespace _06.ReducingNumbers
{
    using System;
    using System.Linq;

    class ReducingNumbers
    {
        static void Main()
        {
            int[] numbers = new int[] { 2, 3, 4, 5, 6, 7, 8, 49, 21, 63, 42};

            Console.WriteLine(String.Join(", ", numbers.Where(x => x % 21 == 0).ToArray()));

            Console.WriteLine(String.Join(", ", (from num in numbers where num % 21 == 0 select num).ToArray()));
        }
    }
}

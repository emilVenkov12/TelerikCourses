namespace _17.ReturnsMaxLenght
{
    using System;
    using System.Linq;

    class ReturnsMaxLenght
    {
        static void Main()
        {
            string[] strings = new string[] { "b", "aa", "aaa", "aaaaa", "cccccc"};

            Console.WriteLine(strings.Aggregate((x, y) => x.Length < y.Length ? y : x));
        }
    }
}

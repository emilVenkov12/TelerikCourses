namespace _02.ReverseString
{
    using System;
    using System.Linq;

    class ReverseString
    {
        //02.Write a program that reads a string, reverses it and prints the result at the console.
        //Example: "sample"  "elpmas".

        static void Main()
        {
            #region Manual Input

            //Console.Write("Enter string: ");
            //char[] input = Console.ReadLine().ToCharArray();

            #endregion

            char[] input = new char[] {'s', 'a', 'm', 'p', 'l', 'e'};
            Console.Write(input);
            Console.Write(" -> ");
            Array.Reverse(input);
            Console.WriteLine(input);
        }
    }
}

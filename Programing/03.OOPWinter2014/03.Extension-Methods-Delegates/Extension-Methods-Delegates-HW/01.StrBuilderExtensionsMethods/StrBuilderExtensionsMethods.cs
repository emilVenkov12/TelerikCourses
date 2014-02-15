namespace _01.StrBuilderExtensionsMethods
{
    using System;
    using System.Text;

    class StrBuilderExtensionsMethods
    {
        //01.Implement an extension method Substring(int index, int length) 
        //for the class StringBuilder that returns new StringBuilder and has
        //the same functionality as Substring in the class String.

        static void Main()
        {
            StringBuilder sb = new StringBuilder("This is substring.");
            //Console.WriteLine("asdsa".Substring(2, 22));
            Console.WriteLine(sb.Substring(1,-20));
        }
    }
}

namespace _01.StrBuilderExtensionsMethods
{
    using System;
    using System.Text;

    class StrBuilderExtensionsMethods
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("This is substring.");
            //Console.WriteLine("asdsa".Substring(2, 22));
            Console.WriteLine(sb.Substring(1,-20));
        }
    }
}

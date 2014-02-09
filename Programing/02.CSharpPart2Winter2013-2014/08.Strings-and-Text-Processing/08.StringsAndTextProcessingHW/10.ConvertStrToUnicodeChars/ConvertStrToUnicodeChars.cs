namespace _10.ConvertStrToUnicodeChars
{
    using System;

    class ConvertStrToUnicodeChars
    {
        //10.Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

        static void Main()
        {
            string text = "Hi!";

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)text[i]);
            }
            Console.WriteLine();
        }
    }
}

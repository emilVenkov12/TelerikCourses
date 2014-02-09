namespace _24.SortWords
{
    using System;
    
    class SortWords
    {
        //24.Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

        static void Main()
        {
            string text = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order".ToLower();

            string[] words = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

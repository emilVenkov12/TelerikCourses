namespace _12.PrintIndexOfLetters
{
    using System;
    class PrintIndexOfLetters
    {
        //12.Write a program that creates an array containing all letters from the alphabet (A-Z). 
        //Read a word from the console and print the index of each of its letters in the array.

        static void Main()
        {
            #region Manual Input
            //Console.Write("Enter word(only letters): ");
            //string word = Console.ReadLine();

            //while (!word.All(Char.IsLetter))
            //{
            //    Console.Write("Enter valid word (only letters): ");
            //    word = Console.ReadLine();
            //}

            #endregion

            string word = "telerikacademy";

            //variant one with array
            char[] letters = new char['Z' - 'A' + 1];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('A' + i);
            }
            //works with lower and upper letters

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", word[i], Array.IndexOf(letters, char.ToUpper(word[i])) + 1);
            }

            //varint two without array
            //Console.WriteLine();
            //for (int i = 0; i < word.Length; i++)
            //{
            //    Console.WriteLine("{0} -> {1}", word[i], (char.ToUpper(word[i]) - 'A' + 1));
            //}
        }
    }
}

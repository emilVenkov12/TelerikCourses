namespace _06.PadRightGivenString
{
    using System;

    class PadRightGivenString
    {
        //06.Write a program that reads from the console a string of maximum 20 characters.
        //If the length of the string is less than 20, the rest of the characters should be
        //filled with '*'. Print the result string into the console.

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter word(max 20 characters): ");
            //string word = Console.ReadLine();

            #endregion

            string word = "qwertyuiqwertyu";

            if (word.Length < 21)
            {
                Console.WriteLine(word.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine("Too many characters!");
            }
        }
    }
}

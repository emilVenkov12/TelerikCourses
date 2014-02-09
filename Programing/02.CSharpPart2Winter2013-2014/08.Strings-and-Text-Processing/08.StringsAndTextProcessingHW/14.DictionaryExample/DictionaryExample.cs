namespace _14.DictionaryExample
{
    using System;
    using System.Collections.Generic;

    class DictionaryExample
    {
        //14.A dictionary is stored as a sequence of text lines containing words and their explanations.
        //Write a program that enters a word and translates it by using the dictionary. 

        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>() 
                {
                    {".NET", "platform for applications from Microsoft"},
                    {"CLR", "managed execution environment for .NET"},
                    {"namespace", "hierarchical organization of classes"}
                };

            string word = ".NET";
            string meaning = String.Empty;
            if (dict.TryGetValue(word, out meaning))
            {
                Console.WriteLine("{0} - {1}", word, meaning);
            }
            else
            {
                Console.WriteLine("The given word is not in dictionary.");
            }
        }
    }
}

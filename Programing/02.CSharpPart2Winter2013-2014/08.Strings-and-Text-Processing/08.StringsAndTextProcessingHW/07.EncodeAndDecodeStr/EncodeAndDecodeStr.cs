namespace _07.EncodeAndDecodeStr
{
    using System;

    class EncodeAndDecodeStr
    {
        //07.Write a program that encodes and decodes a string using given encryption key (cipher). 
        //The key consists of a sequence of characters. The encoding/decoding is done by performing XOR
        //(exclusive or) operation over the first letter of the string with the first of the key, 
        //the second – with the second, etc. When the last key character is reached, the next is the first.

        static void Main()
        {
            string text = "TelerikAcademy",
                key = "ninja";

            string encodedText = String.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                encodedText += (char)(text[i] ^ key[i % key.Length]);
            }

            string decodedText = String.Empty;

            for (int i = 0; i < encodedText.Length; i++)
            {
                decodedText += (char)(encodedText[i] ^ key[i % key.Length]);
            }

            Console.WriteLine("key : {0}, text: {1} -> {2} -> {3}", 
                key, text, encodedText, decodedText);
        }
    }
}

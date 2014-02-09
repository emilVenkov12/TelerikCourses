using System;
using System.Text;

class PrintEntireASCIITable
{
    //12. Find online more information about ASCII (American Standard Code for Information Interchange)
    //and write a program that prints the entire ASCII table of characters on the console.

    static void Main()
    {
        for (char ch = '\u0000'; ch < '\u0080'; ch++)
        {
            Console.WriteLine(ch);   
        }
    }
}


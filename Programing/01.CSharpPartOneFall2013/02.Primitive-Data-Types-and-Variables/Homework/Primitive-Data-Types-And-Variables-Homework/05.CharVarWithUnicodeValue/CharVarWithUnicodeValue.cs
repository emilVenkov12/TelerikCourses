using System;

class CharVarWithUnicodeValue
{
    //05.Declare a character variable and assign it with the symbol that has Unicode code 72. 
    //Hint: first use the Windows Calculator to find the hexadecimal representation of 72
    static void Main()
    {
        char charVar = '\u0048';

        Console.WriteLine("charVar = {0}", charVar);
    }
}

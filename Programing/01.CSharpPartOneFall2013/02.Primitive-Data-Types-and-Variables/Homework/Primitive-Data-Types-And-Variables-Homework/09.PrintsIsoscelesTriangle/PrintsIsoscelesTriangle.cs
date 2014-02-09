using System;
using System.Text;

class PrintsIsoscelesTriangle
{
    //09.Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
    //Use Windows Character Map to find the Unicode code of the © symbol.
    //Note: the © symbol may be displayed incorrectly.

    static void Main()
    {
        //To show sign in the console. First run the program, then go to properties of the window
        //and change font to Lucuda Console.
        char copyrightSymbol = '\u00A9';

        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("   {0}   ", copyrightSymbol);
        Console.WriteLine("  {0} {0}  ", copyrightSymbol);
        Console.WriteLine(" {0}   {0} ", copyrightSymbol);
        Console.WriteLine("{0} {0} {0} {0}", copyrightSymbol);

    }
}

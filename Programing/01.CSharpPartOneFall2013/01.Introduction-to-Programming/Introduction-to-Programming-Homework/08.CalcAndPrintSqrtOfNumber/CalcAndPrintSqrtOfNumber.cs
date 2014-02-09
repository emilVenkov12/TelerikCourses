using System;
class CalcAndPrintSqrtOfNumber
{
    //08.Create a console application that calculates and prints the square of the number 12345.
    static void Main()
    {
        //On the next row it's used placehorder ({n})
        //More about them here : http://www.introprogramming.info/intro-csharp-book/read-online/glava4-vhod-i-izhod-ot-konzolata/#_Toc298863993
        //Alse is used the class Math
        //More about him here : http://msdn.microsoft.com/en-us/library/system.math.aspx
        Console.WriteLine("Square root of {0} is: {1} ", 12345, Math.Sqrt(12345));
    }
}


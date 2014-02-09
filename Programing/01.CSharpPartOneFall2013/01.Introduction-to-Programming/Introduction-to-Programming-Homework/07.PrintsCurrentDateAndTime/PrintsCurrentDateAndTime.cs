using System;

class PrintsCurrentDateAndTime
{
    //07.Create a console application that prints the current date and time.
    static void Main()
    {
        //On the next row it's used placehorder ({n})
        //More about them here : http://www.introprogramming.info/intro-csharp-book/read-online/glava4-vhod-i-izhod-ot-konzolata/#_Toc298863993
        //Also is used the DateTime structure
        //More about DateTime here : http://msdn.microsoft.com/en-us/library/system.datetime.aspx
        Console.WriteLine("Current date and time : {0}", DateTime.Now);
    }
}


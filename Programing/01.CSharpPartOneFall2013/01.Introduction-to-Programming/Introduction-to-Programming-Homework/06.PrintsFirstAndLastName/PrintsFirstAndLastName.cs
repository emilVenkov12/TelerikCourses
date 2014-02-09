using System;

class PrintsFirstAndLastName
{
    //06.Create console application that prints your first and last name.
    //The program prints entered first and last name, instead my.

    static void Main()
    {
        Console.Write("Enter your first name, and press enter : ");
        //This is varaiable of type sting, i'm using her for holding the entered name
        // More about variables can read here : http://www.introprogramming.info/intro-csharp-book/read-online/glava2-primitivni-tipove-i-promenlivi/
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name, and press enter : ");
        string lastName = Console.ReadLine();

        //On the next row it's used placehorder ({n})
        //More about them here : http://www.introprogramming.info/intro-csharp-book/read-online/glava4-vhod-i-izhod-ot-konzolata/#_Toc298863993
        Console.WriteLine("Your name is: {0} {1}", firstName, lastName);

        Console.ReadLine();
    }
}


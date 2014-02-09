using System;

class PrintEnteredName
{
    //03.Modify the application to print your name.

    //I prefer to create a new project, instead to modifying the previous one.
    //Also the program prints the entered name, instead my.
    static void Main()
    {
        Console.Write("Enter your name, and press enter : ");
        //This is varaiable of type sting, i'm using her for holding the entered name
        // More about variables can read here : http://www.introprogramming.info/intro-csharp-book/read-online/glava2-primitivni-tipove-i-promenlivi/
        string enteredName = Console.ReadLine();

        //In the next row it's used placehorder ({n})
        //More about them here : http://www.introprogramming.info/intro-csharp-book/read-online/glava4-vhod-i-izhod-ot-konzolata/#_Toc298863993
        Console.WriteLine("Your name is: {0}", enteredName);

        Console.ReadLine();
    }
}

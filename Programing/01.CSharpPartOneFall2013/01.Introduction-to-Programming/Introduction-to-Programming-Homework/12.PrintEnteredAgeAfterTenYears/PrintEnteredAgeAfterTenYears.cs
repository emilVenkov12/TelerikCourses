using System;

class PrintEnteredAgeAfterTenYears
{
    static void Main()
    {
        // More about variables can read here : http://www.introprogramming.info/intro-csharp-book/read-online/glava2-primitivni-tipove-i-promenlivi/
        int age = 0;
        Console.Write("Enter your age : ");

        //this cycle will iterating again and agani untill entered a valid integer value
        //More about while cycles here : http://www.introprogramming.info/intro-csharp-book/read-online/glava6-cikli/#_Toc298864033
        //More about TryParse method : http://msdn.microsoft.com/en-us/library/system.int32.tryparse.aspx
        //More about out parameters : http://msdn.microsoft.com/en-us/library/ee332485.aspx
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.Write("\nEnter valid age (integer number) : ");            
        }
        

        //This ({n}) is placeholder, more about them here : http://www.introprogramming.info/intro-csharp-book/read-online/glava4-vhod-i-izhod-ot-konzolata/#_Toc298863993
        Console.WriteLine("\nYour age after 10 years will be {0}", age + 10);
    }
}

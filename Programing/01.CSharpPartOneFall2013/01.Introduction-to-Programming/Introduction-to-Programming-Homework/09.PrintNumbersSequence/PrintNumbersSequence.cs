using System;

class PrintNumbersSequence
{
    //09.Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    static void Main()
    {
        //More about for cycle here : http://www.introprogramming.info/intro-csharp-book/read-online/glava6-cikli/#_Toc298864044
        for (int i = 2; i < 12; i++)
        {
            //Checks is the number odd, because infront odd numbers must have minus.
            //More about if construction here: http://www.introprogramming.info/intro-csharp-book/read-online/glava5-uslovni-konstrukcii/#_Toc298864017
            if (i % 2 == 1)
            {
                Console.Write("-");
            }
            Console.Write("{0},",i);
        }
        Console.WriteLine();
    }
}

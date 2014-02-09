using System;

class AssigningStrValueWithQuotes
{
    //08.Declare two string variables and assign them with following value:
    //The "use" of quotations causes difficulties.
    //Do the above in two different ways: with and without using quoted strings.

    static void Main(string[] args)
    {
        string strWithQuotes = "The \"use\" of quotations causes difficulties.";

        string strWithoutQuotes = "The use of quotations causes difficulties.";

        Console.WriteLine("strWithQuotes : {0}", strWithQuotes);
        Console.WriteLine("strWithoutQuotes : {0}", strWithoutQuotes);
    }
}

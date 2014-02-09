using System;

class StringToObjectExample
{
    //07.Declare two string variables and assign them with “Hello” and “World”. 
    //Declare an object variable and assign it with the concatenation of the first
    //two variables (mind adding an interval). Declare a third string variable and 
    //initialize it with the value of the object variable (you should perform type casting).

    static void Main()
    {
        string strHello = "Hello";
        string strWorld = "World";

        object objHelloWorld = strHello + " " + strWorld;

        string strHelloWorld = objHelloWorld.ToString();

        Console.WriteLine("strHello = {0}, strWorld = {1}, objHelloWorld = {2}, \nstrHelloWorld = {3}", 
            strHello, strWorld, objHelloWorld, strHelloWorld);
    }
}


using System;

class NullTypesExample
{
    static void Main()
    {
        int? intNullVar = null;
        double? doubleNullVar = null;

        Console.WriteLine("Before assifning intNullVar = {0}, doubleNullVar = {1}",intNullVar, doubleNullVar);

        intNullVar = 12;
        doubleNullVar = 1.2;

        Console.WriteLine("Before assifning intNullVar = {0}, doubleNullVar = {1}", intNullVar, doubleNullVar);
    }
}
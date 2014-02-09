using System;

class ChangeBitValueOnGivenPos
{
    //12.We are given integer number n, value v (v=0 or 1) and a position p. 
    //Write a sequence of operators that modifies n to hold the value v at the
    //position p from the binary representation of n.
	//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	//n = 5 (00000101), p=2, v=0  1 (00000001)

    static void Main()
    {
        //Console.Write("Enter integer nummber: ");
        //int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid integer number!: ");
        //}

        //Console.Write("Enter position (must be positive and less than 32): ");
        //int position = 0;
        //while (!int.TryParse(Console.ReadLine(), out number) && position < 0 && position > 31)
        //{
        //    Console.Write("Enter a valid position(must be postive)!: ");
        //}

        //Console.Write("Enter value (must be 0 or 1): ");
        //int value = 0;
        //while (!int.TryParse(Console.ReadLine(), out value) && !(position ==0 || position == 1))
        //{
        //    Console.Write("Enter a valid value(must be 0 or 1)!: ");
        //}

        int number = 5,
            position = 3,
            value = 1;

        int mask = 1 << position;
        if (value == 1)
        {
            number = (number | mask);
        }
        else
        {
            number = (number & (~mask));
        }

        Console.WriteLine("The new number is {0}.",number);
    }
}


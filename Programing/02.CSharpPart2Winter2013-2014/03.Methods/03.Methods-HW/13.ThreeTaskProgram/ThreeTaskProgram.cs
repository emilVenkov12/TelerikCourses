namespace _13.ThreeTaskProgram
{
    using System;
    using System.Linq;

    class ThreeTaskProgram
    {
        //13.Write a program that can solve these tasks:
        //Reverses the digits of a number
        //Calculates the average of a sequence of integers
        //Solves a linear equation a * x + b = 0
        //  Create appropriate methods.
        //  Provide a simple text-based menu for the user to choose which task to solve.
        //  Validate the input data:
        //      The decimal number should be non-negative
        //      The sequence should not be empty
        //      a should not be equal to 0

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select task to solve!");
                Console.WriteLine("1 - to revers the digits of number.");
                Console.WriteLine("2 - to calculate the avetrage of a sequance of integers.");
                Console.WriteLine("3 - to solve a linear equation a * x + b = 0.");
                Console.WriteLine("4 - to exit.");

                int choise = 0;
                Console.Write("Enter choise: ");
                while (!int.TryParse(Console.ReadLine(), out choise) || choise < 1 || choise > 4)
                {
                    Console.Write("Enter valid choise: ");
                }

                try
                {
                    switch (choise)
                    {
                        case 1: 
                            {
                                Console.Write("Enter number to revers: ");
                                int number = 0;
                                while (!int.TryParse(Console.ReadLine(), out number))
                                {
                                    Console.Write("Enter valid number to revers: ");
                                }

                                Console.WriteLine("Reversed number: {0}", ReversDigirs(number));
                            }
                            break;
                        case 2:
                            {
                                Console.Write("Enter sequence length: ");
                                int seqLength = 0;
                                while (!int.TryParse(Console.ReadLine(), out seqLength))
                                {
                                    Console.Write("Enter valid length: ");
                                }

                                int[] sequence = new int[seqLength];

                                for (int i = 0; i < seqLength; i++)
                                {
                                    Console.Write("Enter {0}-th number: ", i);
                                    int number = 0;
                                    while (!int.TryParse(Console.ReadLine(), out number))
                                    {
                                        Console.Write("Enter valid {0}-th number: ", i);
                                    }
                                    sequence[i] = number;
                                }
                                Console.WriteLine("Average of the sequence is: {0}", Avarage(null));
                            }
                            break;
                        case 3:
                            {
                                Console.Write("Enter coef a: ");
                                int a = 0;
                                while (!int.TryParse(Console.ReadLine(), out a))
                                {
                                    Console.Write("Enter valid coef. a: ");
                                }

                                Console.Write("Enter coef. x: ");
                                int x = 0;
                                while (!int.TryParse(Console.ReadLine(), out x))
                                {
                                    Console.Write("Enter valid coef. x: ");
                                }

                                Console.Write("Enter coef. b: ");
                                int b = 0;
                                while (!int.TryParse(Console.ReadLine(), out b))
                                {
                                    Console.Write("Enter valid coef. b: ");
                                }

                                Console.WriteLine("Result of equation is : {0}", SolveLinearEquation(a, x, b));
                            }
                            break;
                        case 4: return;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("The following problem has occurred : {0}", e.Message);
                    return;
                }
            }
        }

        static int SolveLinearEquation(int a, int x, int b)
        {
            if (a == 0)
            {
                throw new ArgumentException("a should not be equal to 0");
            }

            return a * x + b;
        }

        static double Avarage(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length < 1)
            {
                throw new ArgumentException("The sequence should not be empty.");
            }

            return numbers.Average();
        }

        static int ReversDigirs(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The decimal number should be non-negative.");
            }
            int result = 0;

            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }
    }
}

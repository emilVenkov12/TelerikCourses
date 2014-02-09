namespace _11._12.PolinomialsOperations
{
    using System;

    class PolinomialsOperations
    {
        //11.Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		//x2 + 5 = 1x2 + 0x + 5  |5|0|1|
        //12.Extend the program to support also subtraction and multiplication of polynomials.

        static void Main()
        {
            int[] firstPol = new int[] { -8, 2, 3 };
            int[] secPol = new int[] { 5, 1 }; 

            Console.WriteLine("First polinomial: {0} \nSecond polinomial: {1}", ToPolinomialString(firstPol), ToPolinomialString(secPol));

            int[] addingResult = AddPolinomials(firstPol, secPol);

            Console.WriteLine("Result of adding: {0}", ToPolinomialString(addingResult));

            int[] subtractingResult = SubPolinomials(firstPol, secPol);

            Console.WriteLine("Result of subtracting: {0}", ToPolinomialString(subtractingResult));

            firstPol = new int[] { -8, 2, 3 };
            secPol = new int[] { 5, 1 }; 
            int[] multiplyResult = MultiplyPolinomials(firstPol, secPol);

            Console.WriteLine("Result of multiplying: {0}", ToPolinomialString(multiplyResult));
        }

        //11
        private static int[] AddPolinomials(int[] firstPol, int[] secPol)
        {
            int[] result = new int[Math.Max(firstPol.Length, secPol.Length)];
            if (firstPol.Length > secPol.Length)
            {
                firstPol.CopyTo(result, 0);
            }
            else
            {
                secPol.CopyTo(result, 0);
            }
            
            for (int i = 0; i < Math.Min(firstPol.Length, secPol.Length); i++)
            {
                result[i] = firstPol[i] + secPol[i];
            }

            return result;
        }

        //12
        private static int[] SubPolinomials(int[] firstPol, int[] secPol)
        {
            for (int i = 0; i < secPol.Length; i++)
            {
                secPol[i] = (~secPol[i]) + 1; // toggle sign
            }

            return AddPolinomials(firstPol, secPol);
        }

        static int[] MultiplyPolinomials(int[] firstPol, int[] secPol)
        {
            int[] result = new int[firstPol.Length + secPol.Length];

            for (int i = 0; i < firstPol.Length; i++)
            {
                for (int j = 0; j < secPol.Length; j++)
                {
                    result[i + j] += firstPol[i] * secPol[j];
                }
            }

            return result;
        }

        static string ToPolinomialString(int[] pol)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            for (int i = pol.Length - 1; i >= 0; i--)
            {
                if (pol[i] != 0)
                {
                    result.AppendFormat("{0} {1}{2} ",
                        pol[i] > 0 ? "+" : "-",
                        Math.Abs(pol[i]), i == 0 ? String.Empty : ("x^" + i));
                }
            }

            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._09._10.GenericMatrixTest
{
    class GenericMatrixTest
    {
        //8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
        //9. Implement an indexer this[row, col] to access the inner matrix cells.
        //10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
        //Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

        static void Main()
        {
            GenericMatrix<double> gm = new GenericMatrix<double>(3, 3);
            gm[0, 0] = 2;
            GenericMatrix<double> gm2 = new GenericMatrix<double>(3, 3);
            gm2[0, 0] = 3.1;

            GenericMatrix<double> result = gm + gm2;
            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine(result.ToString());
        }
    }
}

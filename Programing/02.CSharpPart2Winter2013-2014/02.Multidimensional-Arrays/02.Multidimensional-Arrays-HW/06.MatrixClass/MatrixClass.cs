namespace _06.MatrixClass
{
    using System;
    class MatrixClass
    {
        //06.* Write a class Matrix, to holds a matrix of integers. Overload the operators for adding,
        //subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

        static void Main()
        {
            Matrix m1 = new Matrix(3, 3);
            Matrix m2 = new Matrix(3, 3);

            Random randGen = new Random();

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    m1[i, j] = randGen.Next(50);
                    m2[i, j] = randGen.Next(50);
                }
            }

            Console.WriteLine("First matrix: {0}", m1.ToString());
            Console.WriteLine("Second matrix: {0}", m2.ToString());
            Console.WriteLine();

            Matrix resultOfAdditon = m1 + m2;

            Console.WriteLine("Result of additon: {0}", resultOfAdditon);

            Matrix resultOfSubstraction = m1 - m2;

            Console.WriteLine("Result of substraction: {0}", resultOfSubstraction);


            Matrix resultOfMul = m1 * m2;

            Console.WriteLine("Result of multiplication: {0}", resultOfMul);
        }
    }

    class Matrix
    {
        #region Fields

        private int[,] matrix;
        private int rows;
        private int cols;

        #endregion

        #region Properties

        public int Rows
        {
            get 
            {
                return this.rows; 
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The rows should be positive and bigger than zero.");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The colums should be positive and bigger than zero.");
                }
                this.cols = value;
            }
        }

        #endregion

        #region Constuctors

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;

            this.matrix = new int[this.rows, this.cols];
        }

        public int this[int x, int y]
        {
            get
            {
                return this.matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }

        #endregion

        #region Methods

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || 
                    firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The matrices are not with same size.");
            }

            Matrix result = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
			{
                for (int j = 0; j < firstMatrix.Cols; j++)
			    {
                    result[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
			    }
			}

            return result;
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                    firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The matrices are not with same size.");
            }

            Matrix result = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("The matrices are not with proper size for multiplication.");
            }

            Matrix result = new Matrix(firstMatrix.Rows, secondMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("{");

            for (int i = 0; i < this.rows; i++)
            {
                sb.Append("   {");
                for (int j = 0; j < this.cols; j++)
                {
                    sb.AppendFormat("{0}, ", this[i, j]);
                }
                sb.Length -= 2;
                sb.AppendLine("},");
            }
            sb.AppendLine("}");

            return sb.ToString();
        }

        #endregion

    }
}

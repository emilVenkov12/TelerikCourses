namespace _08._09._10.GenericMatrixTest
{
    using System;

    class GenericMatrix<T> where T : struct, IComparable, IEquatable<T>
    {
        #region Fields and Properties

        private T[,] matrix;

        private int rows;
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

        private int cols;

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

        public GenericMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;

            this.matrix = new T[this.rows, this.cols];
        }



        #endregion

        #region Methods
        public T this[int x, int y]
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
        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                    firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The matrices are not with same size.");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                    firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The matrices are not with same size.");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("The matrices are not with proper size for multiplication.");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.Rows, secondMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        result[i, j] += (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }

            return result;
        }
        public static bool operator true(GenericMatrix<T> mat)
        {
            foreach (var item in mat.matrix)
            {
                if ((dynamic)item != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator false(GenericMatrix<T> mat)
        {
            foreach (var item in mat.matrix)
            {
                if ((dynamic)item != 0)
                {
                    return true;
                }
            }

            return false;
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

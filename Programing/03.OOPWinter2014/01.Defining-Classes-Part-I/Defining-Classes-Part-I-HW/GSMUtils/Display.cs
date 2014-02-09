namespace GSMUtils
{
    using System;

    public class Display
    {
        #region Fields and Propeties

        private double size;

        public double Size
        {
            get { return size; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument size should be non-negative or equal to zero.");
                }
                size = value;
            }
        }

        private long colorsNumber;

        public long ColorsNumber
        {
            get { return colorsNumber; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument colorsNumber should be non-negative or equal to zero.");
                }
                colorsNumber = value;
            }
        }

        #endregion

        #region Constructors

        public Display(double size, long colorsNumber)
        {
            this.Size = size;
            this.ColorsNumber = colorsNumber;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("Size: {0}; Number of Colors: {1};", 
                this.Size, this.ColorsNumber);
        }

        #endregion
    }
}

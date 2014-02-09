namespace GeometryUtils
{
    using System;
    using System.Linq;

    public struct Point3D
    {
        #region Fields and Properties

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        private static readonly Point3D zeroPoint = new Point3D();

        public static Point3D ZeroPoint
        {
            get { return Point3D.zeroPoint; }
        } 

        #endregion

        #region Constructors

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #endregion

        #region Methods

        public static Point3D Parse(string point)
        {
            double[] coords = point.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            return new Point3D(coords[0], coords[1], coords[2]);
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }

        #endregion
    }
}

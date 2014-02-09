namespace GeometryUtils
{
    using System;
    using System.Collections.Generic;

    public class Path : List<Point3D>
    {

        public Path(params Point3D[] points)
        {
            this.AddRange(points);
        }

        public override string ToString()
        {
            return String.Join("\n", this);
        }
    }
}

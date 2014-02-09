namespace GeometryUtils
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        #region Methods

        public static Path LoadPoints(string filePath)
        {
            return new Path(File.ReadAllLines(filePath).Select(Point3D.Parse).ToArray());
        }

        public static void SavePointsToFile(Path path, string filePath)
        {
            File.WriteAllText(filePath, path.ToString());
        }

        #endregion
    }
}

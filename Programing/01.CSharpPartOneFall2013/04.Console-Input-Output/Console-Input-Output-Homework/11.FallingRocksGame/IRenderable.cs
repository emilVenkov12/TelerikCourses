using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FallingRocksGame
{
    public interface IRenderable
    {
        MatrixCoords GetTopLeft();

        char[,] GetImage();
    }
}

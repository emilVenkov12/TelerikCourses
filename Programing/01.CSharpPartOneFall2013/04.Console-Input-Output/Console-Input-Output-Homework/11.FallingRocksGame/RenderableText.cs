using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FallingRocksGame
{
    class RenderableText : IRenderable
    {
        private string text;
        private MatrixCoords topLeftPos;

        public string Text
        {
            get { return this.text; }
            protected set { this.text = value; }
        }

        public RenderableText(string text, MatrixCoords topLeftPos)
        {
            this.Text = text;
            this.topLeftPos = topLeftPos;
        }

        public MatrixCoords GetTopLeft()
        {
            return this.topLeftPos;
        }

        public char[,] GetImage()
        {
            char[] row = this.text.ToCharArray();
            char[,] image = new char[1, row.Length];
            for (int i = 0; i < row.Length; i++)
            {
                image[0, i] = row[i];
            }
            return image;
        }
    }
}

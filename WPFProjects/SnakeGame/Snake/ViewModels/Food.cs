using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake.ViewModels
{
    public class Food : Figure
    {
        #region Constructors

        public Food(int size, int x, int y) 
            : base(size, x, y)
        {
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake.ViewModels
{    
    public abstract class Figure : ViewModelBase
    {
        #region Fields

        private int x;
        private int y;

        #endregion
        #region Properties

        public int Size { get; protected set; }

        public int X 
        {
            get { return this.x; }
            set 
            {
                this.x = value;
                this.OnPropertyChanged("X");
            }
        }

        public int Y 
        {
            get { return this.y; }
            set 
            {
                this.y = value;
                this.OnPropertyChanged("Y");
            }
        }
        #endregion

        #region Constructors

        public Figure(int size, int x, int y)
        {
            this.Size = size;
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            Figure other = obj as Figure;
            if (other == null)
            {
                return false;
            }
            return this.X == other.X && this.Y == other.Y;
        }

        #endregion
    }
}

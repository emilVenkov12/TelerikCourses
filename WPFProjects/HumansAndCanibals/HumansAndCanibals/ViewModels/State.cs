using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumansAndCanibals.ViewModels
{
    public class State : ICloneable
    {
        #region Fields

        private Shore leftShore;
        private Shore rightShore;
        private char boatPos;

        #endregion

        #region Properties

        public Shore LeftShore
        {
            get { return leftShore; }
            set { leftShore = value; }
        }

        public Shore RightShore
        {
            get { return rightShore; }
            set { rightShore = value; }
        }

        public char BoatPos
        {
            get { return boatPos; }
            set { boatPos = value; }
        }

        #endregion

        #region Constructors

        public State() 
            : this(new Shore(), new Shore(), 'L') { }

        public State(Shore leftShore, Shore rightShore, char boatPos) 
        {
            this.LeftShore = leftShore;
            this.RightShore = rightShore;
            this.BoatPos = boatPos;
        }

        #endregion


        #region Methods

        public override bool Equals(object obj)
        {
            State other = obj as State;

            if (other == null)
            {
                return false;
            }

            return this.LeftShore.Equals(other.leftShore)
                && this.RightShore.Equals(other.rightShore)
                && this.BoatPos.Equals(other.BoatPos);
        }

        public override string ToString()
        {
            return String.Format("LeftShore: {0}, RightShore : {1}, Boat:{2}",
                this.LeftShore.ToString(), this.RightShore.ToString(),
                this.BoatPos.ToString());
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new State(this.leftShore.Clone() as Shore,
                this.rightShore.Clone() as Shore, this.BoatPos);
        }

        #endregion
    }
}

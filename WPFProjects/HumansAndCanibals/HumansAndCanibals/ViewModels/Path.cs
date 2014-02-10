using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumansAndCanibals.ViewModels
{
    public class Path : List<State>, ICloneable
    {
        #region Constructors

        public Path() : base()
        { }

        public Path(IEnumerable<State> collection)
            : base(collection)
        { }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {            
            Path other = obj as Path;
            if (other == null)
            {
                return false;
            }

            if (this.Count != other.Count)
            {
                return false;
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (!this[i].Equals(other[i]))
                {
                    return false;
                }
            }
            return true;
        }
        
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new Path(this);
        }

        #endregion
    }
}

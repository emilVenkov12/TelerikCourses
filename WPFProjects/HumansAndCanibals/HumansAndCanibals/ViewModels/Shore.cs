using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace HumansAndCanibals.ViewModels
{
    public class Shore : ViewModelBase, ICloneable
    {
        #region Fields

        private List<Cannibal> cannibals;
        private List<Missionier> missionaries;
        
        #endregion

        #region Properties

        public List<Cannibal> Cannibals
        {
            get { return cannibals; }
            set 
            {
                cannibals = value;
                this.OnPropertyChanged("CannibalsCount");
            }
        }

        public List<Missionier> Missionaries
        {
            get { return missionaries; }
            set 
            {
                missionaries = value;
                this.OnPropertyChanged("MissionariesCount");
            }
        }

        #endregion

        #region Constructors

        public Shore() : this(new List<Cannibal>(), new List<Missionier>()) { }

        public Shore(List<Cannibal> cannibalsCount, List<Missionier> missionariesCount)
        {
            this.Cannibals = cannibalsCount;
            this.Missionaries = missionariesCount;
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            Shore other = obj as Shore;
            if (other == null)
            {
                return false;
            }            
            return this.Cannibals.Count == other.Cannibals.Count
                && this.Missionaries.Count == other.Missionaries.Count;
        }

        public override string ToString()
        {
            return String.Format("{0}m, {1}c", this.Missionaries.Count,
                this.Cannibals.Count);
        }

        public static Shore operator -(Shore firstShore, Shore secShore)
        {
            return GetNewShore(Math.Abs(firstShore.Cannibals.Count - secShore.Cannibals.Count),
                Math.Abs(firstShore.Missionaries.Count - secShore.Missionaries.Count));
        }
        public static Shore operator +(Shore firstShore, Shore secShore)
        {
            return GetNewShore(firstShore.Cannibals.Count + secShore.Cannibals.Count,
                firstShore.Missionaries.Count + secShore.Missionaries.Count);
        }
        private static Shore GetNewShore(int cannCount, int missCount)
        {
            List<Cannibal> cann = new List<Cannibal>();
            for (int i = 0; i < cannCount; i++)
                cann.Add(new Cannibal());

            List<Missionier> miss = new List<Missionier>();
            for (int i = 0; i < missCount; i++)
                miss.Add(new Missionier());

            return new Shore(cann, miss);
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new Shore(this.Cannibals, this.Missionaries);
        }

        #endregion
    }
}

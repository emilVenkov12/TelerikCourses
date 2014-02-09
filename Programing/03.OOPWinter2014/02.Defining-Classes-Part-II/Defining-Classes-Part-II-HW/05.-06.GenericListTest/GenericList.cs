namespace _05._06.GenericListTest
{
    using System;
    using System.Collections;

    public class GenericList<T> where T : IComparable
    {
        #region Fields and Properties

        private T[] list;

        private long currElem = 0;

        private long capacity;

        public long Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument capacity should be non-negative and not equal to zero.");
                }
                capacity = value;
            }
        }

        public long Count
        {
            get { return this.currElem; }
        }

        #endregion

        #region Constuctors

        public GenericList()
            : this(1)
        { }

        public GenericList(long capacity)
        {
            this.Capacity = capacity;
            this.list = new T[capacity];
        }

        #endregion

        #region Methods

        public T this[long index]
        {
            get
            {
                IsValid(index);
                return this.list[index];
            }
            set
            {
                IsValid(index);
                this.list[index] = value;
            }
        }

        public void Add(T elem)
        {
            if (elem == null)
            {
                throw new ArgumentNullException("elem");
            }

            if (this.currElem >= this.capacity)
            {
                this.ResizeList();
            }
            this.list[this.currElem++] = elem;
        }

        public void AddRange(params T[] elems)
        {
            foreach (var elem in elems)
            {
                this.Add(elem);
            }
        }

        public void RemoveAt(long index)
        {
            IsValid(index);

            if (index != this.currElem - 1)
            {
                Array.Copy(this.list, index + 1, this.list, index, this.Count - index);
            }
            this.currElem--;

        }

        public void InsertAt(long index, T elem)
        {
            IsValid(index);
            if (index == this.currElem)
            {
                this.Add(elem);
            }
            else
            {
                this.currElem++;
                if (this.currElem >= this.capacity)
                {
                    this.ResizeList();
                }
                Array.Copy(this.list, index, this.list, index + 1, this.Count - index);
                this.list[index] = elem;
            }
        }

        public void Clear()
        {
            this.currElem = 0;
        }

        public long IndexOf(T elem)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (list[i].Equals(elem))
                {
                    return i;
                }
            }
            return -1;
        }

        private void ResizeList()
        {
            this.capacity *= 2;
            T[] newArr = new T[this.capacity];
            Array.Copy(this.list, newArr, this.list.Length);
            this.list = newArr;
        }

        private void IsValid(long index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the array.");
            }
        }

        public T Min()
        {
            T min = this.list[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.list[i].CompareTo(min) < 0)
                {
                    min = this.list[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.list[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.list[i].CompareTo(max) > 0)
                {
                    max = this.list[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                sb.AppendFormat("{0}, ", this.list[i]);
            }
            sb.Length -= 2;

            return sb.ToString();
        }

        #endregion
    }
}
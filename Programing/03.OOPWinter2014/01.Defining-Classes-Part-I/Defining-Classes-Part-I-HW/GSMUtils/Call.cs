namespace GSMUtils
{
    using System;

    public class Call : IComparable<Call>
    {
        #region Fields and Properties

        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("dateTime");
                }
                dateTime = value;
            }
        }

        private string dialedPhoneNumber;

        public string DialedPhoneNumber
        {
            get { return dialedPhoneNumber; }
            protected set 
            {
                //may be add some regex to check number
                if (value == String.Empty)
                {

                    throw new ArgumentException("Argument dialedPhoneNumber shouldn't be empty.");
                }
                dialedPhoneNumber = value;
            }
        }

        private long duration;

        public long Duration
        {
            get { return duration; }
            protected set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Argument duration should be non-negative or equal to zero.");
                }
                duration = value; 
            }
        }

        #endregion

        #region Constructors

        public Call(DateTime dateTime, string dialedPhoneNumber, long duration)
        {
            this.DateTime = dateTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("DateTime: {0}; Dialed phone number: {1}, Duration: {2}",
                this.DateTime.ToString(), this.DialedPhoneNumber, this.Duration);
        }

        public override bool Equals(object obj)
        {
            Call other = obj as Call;
            if (other == null)
            {
                return false;
            }

            return this.DateTime == other.DateTime && 
                this.DialedPhoneNumber == other.DialedPhoneNumber && this.Duration == other.Duration;
        }

        #endregion

        public int CompareTo(Call other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            return (int)(this.Duration - other.Duration);
        }
    }
}

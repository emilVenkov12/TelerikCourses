namespace GSMUtils
{
    using System;

    public class Battery
    {
        #region Fields and Properties

        private string model;

        public string Model
        {
            get { return model; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("model");
                }
                model = value;
            }
        }

        private double hoursIdle;

        public double HoursIdle
        {
            get { return hoursIdle; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Argument hoursIdle should be non-negative.");
                }
                hoursIdle = value;
            }
        }

        private double hoursTalk;

        public double HoursTalk
        {
            get { return hoursTalk; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Argument hoursTalk should be non-negative.");
                }
                hoursTalk = value;
            }
        }

        private BatteryType type;

        public BatteryType Type
        {
            get { return type; }
            protected set { type = value; }
        }

        #endregion

        #region Constructors

        public Battery(BatteryType type)
            : this(type, null)
        { }

        public Battery(BatteryType type, string model)
            : this(type, model, 0)
        { }

        public Battery(BatteryType type, string model, double hoursIdle)
            : this(type, model, hoursIdle, 0)
        { }

        public Battery(BatteryType type, string model, double hoursIdle, double hoursTalk)
        {
            this.Type = type;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("Model :{0}; Hours Idle :{1}; Hours Talk:{2}; Type: {3}",
                this.Model, this.HoursIdle, this.HoursTalk, this.type);
        }

        #endregion
    }
}

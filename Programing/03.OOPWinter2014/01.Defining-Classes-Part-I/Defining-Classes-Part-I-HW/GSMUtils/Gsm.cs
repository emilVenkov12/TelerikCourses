namespace GSMUtils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Gsm
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
                if (value == String.Empty)
                {
                    throw new ArgumentException("Argument model shouldn't be empty.");
                }
                model = value;
            }
        }

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("manufacturer");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Argument manufacturer shouldn't be empty.");
                }
                manufacturer = value;
            }
        }

        private double? price;

        public double? Price
        {
            get { return price; }
            protected set
            {
                if (value != null && value.Value <= 0)
                {
                    throw new ArgumentException("Argument price should be non-negative and not equal to 0.");
                }
                price = value;
            }
        }

        private string owner;

        public string Owner
        {
            get { return owner; }
            protected set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Argument owner shouldn't be empty.");
                }
                owner = value;
            }
        }

        private Battery batteryCharacts;

        public Battery BatteryCharacts
        {
            get { return batteryCharacts; }
            protected set { batteryCharacts = value; }
        }

        private Display displayCharacts;

        public Display DisplayCharacts
        {
            get { return displayCharacts; }
            protected set { displayCharacts = value; }
        }

        private List<Call> callHistory;
        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory.ToArray()); }
            protected set { this.callHistory = value; }
        }

        public static Gsm IPhone4S = new Gsm("Iphone4S", "Apple", 450.00, "Timothy D. Cook",
            new Battery(BatteryType.Lilon, "IF115-005-2", 200, 14), new Display(4, 16777216));

        #endregion

        #region Constructors
        public Gsm(string model, string manufacturer)
            : this(model, manufacturer, null)
        { }

        public Gsm(string model, string manufacturer, double? price)
            : this(model, manufacturer, price, null)
        { }

        public Gsm(string model, string manufacturer, double? price, string owner)
            : this(model, manufacturer, price, owner, null)
        { }

        public Gsm(string model, string manufacturer, double? price, string owner, Battery batteryCharacts)
            : this(model, manufacturer, price, owner, batteryCharacts, null)
        { }

        public Gsm(string model, string manufacturer, double? price, string owner, Battery batteryCharacts, Display displayCharacts)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryCharacts = batteryCharacts;
            this.DisplayCharacts = displayCharacts;

            this.CallHistory = new List<Call>();
        }

        #endregion

        #region Methods

        public void AddCall(Call callToAdd)
        {
            if (callToAdd == null)
            {
                throw new ArgumentNullException("callToAdd");
            }

            this.callHistory.Add(callToAdd);
        }

        public void RemoveCall(Call callToRemove)
        {
            if (callToRemove == null)
            {
                throw new ArgumentNullException("callToRemove");
            }

            this.callHistory.Remove(callToRemove);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public double CalcCallsPrice(double pricePerMin)
        {
            if (pricePerMin < 0)
            {
                throw new ArgumentException("Argument pricePerMin should be non-negative.");
            }

            double callsPrice = this.callHistory.Sum(x => ((x.Duration / 60) + (x.Duration % 60 > 0 ? 1 : 0)) * pricePerMin);

            return callsPrice;
        }
        public override string ToString()
        {
            return String.Format("Model: {0}; Manufacturer: {1}; Price: {2};\nOwner: {3};\nBattery characteristics: {4};\nDisplay characteristics: {5};\nCallHistory: {6}",
                this.model, this.manufacturer,
                this.price == null ? "unknown" : price.Value.ToString(), this.owner ?? "unknown",
                this.batteryCharacts == null ? "unknown" : this.batteryCharacts.ToString(),
                this.displayCharacts == null ? "unknown" : this.displayCharacts.ToString(),
                this.CallHistory.Count > 0 ? "\n" + String.Join(";\n", this.CallHistory) : "none");
        }

        #endregion
    }
}

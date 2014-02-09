namespace _11.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Class | 
        AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Method,
        AllowMultiple = false)]
    class VersionAttribute : Attribute
    {
        public int Major { get; private set; }

        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return String.Format("{0}.{1}", this.Major, this.Minor);
        }
    }
}

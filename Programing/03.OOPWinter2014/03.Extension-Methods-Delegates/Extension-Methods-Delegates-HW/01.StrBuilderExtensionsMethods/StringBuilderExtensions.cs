namespace _01.StrBuilderExtensionsMethods
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "Index cannot be less than zero.");
            }

            if (index > strBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("index", "Index cannot be larger than length of the string builder.");
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException("length", "Length cannot be less than zero.");
            }

            if (index + length > strBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("length", "Index and length must refer to a location within the string builder.");
            }

            StringBuilder newStrBuilder = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                newStrBuilder.Append(strBuilder[i]);
            }

            return newStrBuilder;

            //or
            //return new StringBuilder(strBuilder.ToString(index, length));
        }
    }
}

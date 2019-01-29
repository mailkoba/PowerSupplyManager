using System;

namespace PowerSupplyManager
{
    internal static class Assertion
    {
        public static void IsNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void IsNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}

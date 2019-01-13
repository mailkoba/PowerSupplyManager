using System;

namespace PowerSupplyManager
{
    internal static class Assertion
    {
        public static void IsNullOrEmpty(this string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}

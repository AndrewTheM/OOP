using System;
using System.Runtime.CompilerServices;

namespace InfernoInfinity.Helpers
{
    public static class PropertyCheck
    {
        public static string StringNotEmpty(string value, [CallerMemberName] string propName = "")
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{propName} cannot be empty.");
            return value;
        }

        public static int NumberNotNegative(int value, [CallerMemberName] string propName = "")
            => (int)NumberNotNegative((double)value, propName);

        public static int NumberPositive(int value, [CallerMemberName] string propName = "")
            => (int)NumberPositive((double)value, propName);

        public static double NumberNotNegative(double value, [CallerMemberName] string propName = "")
        {
            if (value < 0)
                throw new ArgumentException($"{propName} cannot be negative.");
            return value;
        }

        public static double NumberPositive(double value, [CallerMemberName] string propName = "")
        {
            if (value < 0)
                throw new ArgumentException($"{propName} cannot be negative.");
            return value;
        }
    }
}

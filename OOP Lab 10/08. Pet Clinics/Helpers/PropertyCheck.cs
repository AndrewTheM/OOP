using System;

namespace PetClinics.Helpers
{
    public static class PropertyCheck
    {
        public static string StringNotEmpty(string value, string propName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{propName} cannot be empty.");
            return value;
        }

        public static int NumberNotNegative(int value, string propName)
            => (int)NumberNotNegative((double)value, propName);

        public static int NumberPositive(int value, string propName)
            => (int)NumberPositive((double)value, propName);

        public static double NumberNotNegative(double value, string propName)
        {
            if (value < 0)
                throw new ArgumentException($"{propName} cannot be negative.");
            return value;
        }

        public static double NumberPositive(double value, string propName)
        {
            if (value < 0)
                throw new ArgumentException($"{propName} cannot be negative.");
            return value;
        }
    }
}

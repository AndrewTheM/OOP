using System;

namespace ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        protected double Length
        {
            get => length;
            set => length = ValidateValue(value, nameof(Length));
        }

        protected double Width
        {
            get => width;
            set => width = ValidateValue(value, nameof(Width));
        }

        protected double Height
        {
            get => height;
            set => height = ValidateValue(value, nameof(Height));
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        private double ValidateValue(double value, string propName)
        {
            if (value <= 0)
                throw new ArgumentException($"{propName} cannot be zero or negative.");
            return value;
        }

        public double GetSurfaceArea()
            => GetLateralSurfaceArea() + length * width * 2;

        public double GetLateralSurfaceArea()
            => height * 2 * (length + width);

        public double GetVolume()
            => length * width * height;
    }
}

using System;
using System.Text;

namespace Shapes.Models
{
    public class Circle : Shape
    {
        private int radius;

        public int Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius cannot be negative or zero.");
                radius = value;
            }
        }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

        public override string Draw()
        {
            var strBuilder = new StringBuilder();

            for (int y = -Radius; y <= Radius; ++y)
            {
                for (double x = -Radius; x <= Radius + 0.4; x += 0.5)
                {
                    double sqRadius = x * x + y * y;
                    if (sqRadius >= Math.Pow(Radius - 0.4, 2) && sqRadius <= Math.Pow(Radius + 0.4, 2))
                    {
                        strBuilder.Append("#");
                    }
                    else
                    {
                        strBuilder.Append(' ');
                    }
                }
                strBuilder.AppendLine();
            }

            return strBuilder.ToString();
        }
    }
}

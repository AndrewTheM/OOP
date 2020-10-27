using System;
using System.Text;

namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public int Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height cannot be negative or zero");
                height = value;
            }
        }

        public int Width
        {
            get => width;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Width cannot be negative or zero");
                width = value;
            }
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter() => (Height + Width) * 2;

        public override double CalculateArea() => Height * Width;

        public override string Draw()
        {
            var strBuilder = new StringBuilder();

            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j < Width; ++j)
                {
                    strBuilder.Append("#");
                }
                strBuilder.AppendLine();
            }

            return strBuilder.ToString();
        }
    }
}

using System;

namespace FigureDrawing.Models
{
    public class Rectangle : IDrawable
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            if (Width <= 0)
                return;

            for (int i = 0; i < Height; ++i)
            {
                Console.Write("|");
                for (int j = 0; j < Width; ++j)
                    Console.Write((i == 0 || i == Height - 1) ? "-" : " ");
                Console.WriteLine("|");
            }
        }
    }
}

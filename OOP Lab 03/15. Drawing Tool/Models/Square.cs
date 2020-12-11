using System;

namespace FigureDrawing.Models
{
    public class Square : IDrawable
    {
        public int Size { get; set; }

        public Square(int size)
        {
            Size = size;
        }

        public void Draw()
        {
            for (int i = 0; i < Size; ++i)
            {
                Console.Write("|");
                for (int j = 0; j < Size; ++j)
                    Console.Write((i == 0 || i == Size - 1) ? "-" : " ");
                Console.WriteLine("|");
            }
        }
    }
}

using FigureDrawing.Models;
using System;

namespace FigureDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            IDrawable figure = type switch
            {
                "Square" => new Square(int.Parse(Console.ReadLine())),
                "Rectangle" => new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())),
                _ => null
            };

            Console.WriteLine();

            var tool = new DrawingTool(figure);
            tool.DrawFigure();

            Console.ReadKey();
        }
    }
}

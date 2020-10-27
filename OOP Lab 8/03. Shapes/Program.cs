using Shapes.Models;
using System;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shape rectangle = new Rectangle(4, 9);
            Shape circle = new Circle(20);

            Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter():0.00}");
            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea():0.00}");
            Console.WriteLine(Environment.NewLine + rectangle.Draw());

            Console.WriteLine($"Circle perimeter: {circle.CalculatePerimeter():0.00}");
            Console.WriteLine($"Circle area: {circle.CalculateArea():0.00}");
            Console.WriteLine(Environment.NewLine + circle.Draw());

            Console.ReadKey();
        }
    }
}

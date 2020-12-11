using System;

namespace ClassBoxDataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double length = double.Parse(Console.ReadLine().Replace('.', ',')),
                    width = double.Parse(Console.ReadLine().Replace('.', ',')),
                    height = double.Parse(Console.ReadLine().Replace('.', ','));

                var box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():0.00}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():0.00}");
                Console.WriteLine($"Volume - {box.GetVolume():0.00}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

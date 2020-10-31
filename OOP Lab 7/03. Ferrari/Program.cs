using ClassFerrari.Models;
using System;

namespace ClassFerrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driverName);

            Console.WriteLine($"{ferrari.Model}/{ferrari.UseBrakes()}/" +
                              $"{ferrari.PushGasPedal()}/{ferrari.DriverName}");
            Console.ReadKey();
        }
    }
}

using EventImplementation.Models;
using System;

namespace EventImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();
            dispatcher.NameChanged += handler.OnDispatcherNameChanged;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                dispatcher.Name = line;
            }

            Console.ReadKey();
        }
    }
}

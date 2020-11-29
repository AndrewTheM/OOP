using System;
using System.Collections.Generic;
using TrafficLights.Models;

namespace TrafficLights
{
    class Program
    {
        static void Main(string[] args)
        {
            var trafficLights = new List<TrafficLight>();

            var signalNames = Console.ReadLine().Split(' ');
            int changeCount = int.Parse(Console.ReadLine());

            foreach (var name in signalNames)
            {
                try
                {
                    SignalState signal = name.ToLower() switch
                    {
                        "red" => new RedSignalState(),
                        "yellow" => new YellowSignalState(),
                        "green" => new GreenSignalState(),
                        _ => throw new Exception($"Invalid signal: {name}")
                    };

                    var trafficLight = new TrafficLight(signal);
                    trafficLights.Add(trafficLight);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < changeCount; ++i)
            {
                foreach (var tl in trafficLights)
                {
                    tl.SwitchSignal();
                    Console.Write($"{tl.State.SignalName} ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

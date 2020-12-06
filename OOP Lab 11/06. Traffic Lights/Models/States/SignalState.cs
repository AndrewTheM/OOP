using System;
using System.Linq;
using TrafficLights.Contracts;

namespace TrafficLights.Models
{
    public abstract class SignalState : ISignalState
    {
        public ITrafficLight Context { get; protected set; }

        public string SignalName
        {
            get
            {
                return GetType().Name
                       .Split(nameof(SignalState), StringSplitOptions.RemoveEmptyEntries)
                       .FirstOrDefault();
            }
        }

        public abstract void Switch();
    }
}

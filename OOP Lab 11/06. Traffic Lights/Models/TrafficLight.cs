using System;
using TrafficLights.Contracts;

namespace TrafficLights.Models
{
    public class TrafficLight : ITrafficLight
    {
        public ISignalState State { get; private set; }

        public TrafficLight()
            : this(new RedSignalState())
        {
        }

        public TrafficLight(ISignalState state)
        {
            ChangeState(state);
        }

        public void ChangeState(ISignalState state)
        {
            State = state
                ?? throw new ArgumentNullException(nameof(state));

            var contextProp = State.GetType()
                                   .GetProperty(nameof(State.Context));
            contextProp.SetValue(State, this);
        }

        public void Switch() => State.Switch();
    }
}

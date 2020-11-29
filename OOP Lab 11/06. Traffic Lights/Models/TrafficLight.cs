using System;
using System.Reflection;

namespace TrafficLights.Models
{
    public class TrafficLight
    {
        public SignalState State { get; private set; }

        public TrafficLight()
            : this(new RedSignalState())
        {
        }

        public TrafficLight(SignalState state)
        {
            ChangeState(state);
        }

        private void ChangeState(SignalState state)
        {
            State = state
                ?? throw new ArgumentNullException(nameof(state));

            var type = State.GetType();
            var flags = BindingFlags.NonPublic | BindingFlags.Instance;
            var setContextMethod = type.GetMethod("SetContext", flags);
            setContextMethod.Invoke(State, new object[] { this });
        }

        public void SwitchSignal()
            => State.SwitchSignal();
    }
}

using System;
using System.Reflection;

namespace TrafficLights.Models
{
    public abstract class SignalState
    {
        protected TrafficLight trafficLight;
        protected MethodInfo changeStateMethod;

        public string SignalName { get; }

        protected SignalState(string signalName)
            => SignalName = signalName;

        protected void SetContext(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight
                ?? throw new ArgumentNullException(nameof(trafficLight));

            var type = trafficLight.GetType();
            var flags = BindingFlags.NonPublic | BindingFlags.Instance;
            changeStateMethod = type.GetMethod("ChangeState", flags);
        }

        protected void ChangeContextState(SignalState state)
        {
            var parameters = new object[] { state };

            if (changeStateMethod != null)
                changeStateMethod.Invoke(trafficLight, parameters);
            else
                throw new InvalidOperationException("The state has no context.");
        }

        public abstract void SwitchSignal();
    }
}

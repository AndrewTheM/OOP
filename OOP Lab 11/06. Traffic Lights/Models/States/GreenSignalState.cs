namespace TrafficLights.Models
{
    public class GreenSignalState : SignalState
    {
        public GreenSignalState() : base("Green")
        {
        }

        public override void SwitchSignal()
            => ChangeContextState(new YellowSignalState());
    }
}
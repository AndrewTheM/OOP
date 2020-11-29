namespace TrafficLights.Models
{
    public class RedSignalState : SignalState
    {
        public RedSignalState() : base("Red")
        {
        }

        public override void SwitchSignal()
            => ChangeContextState(new GreenSignalState());
    }
}

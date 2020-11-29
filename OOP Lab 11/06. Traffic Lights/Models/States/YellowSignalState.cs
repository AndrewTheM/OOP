namespace TrafficLights.Models
{
    public class YellowSignalState : SignalState
    {
        public YellowSignalState() : base("Yellow")
        {
        }
        
        public override void SwitchSignal()
            => ChangeContextState(new RedSignalState());
    }
}
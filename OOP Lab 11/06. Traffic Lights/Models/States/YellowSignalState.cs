namespace TrafficLights.Models
{
    public class YellowSignalState : SignalState
    {
        public override void Switch()
            => Context.ChangeState(new RedSignalState());
    }
}
namespace TrafficLights.Models
{
    public class GreenSignalState : SignalState
    {
        public override void Switch()
            => Context.ChangeState(new YellowSignalState());
    }
}
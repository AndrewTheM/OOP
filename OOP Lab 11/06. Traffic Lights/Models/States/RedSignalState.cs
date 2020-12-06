namespace TrafficLights.Models
{
    public class RedSignalState : SignalState
    {
        public override void Switch()
            => Context.ChangeState(new GreenSignalState());
    }
}

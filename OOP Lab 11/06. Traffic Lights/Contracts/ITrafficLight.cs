namespace TrafficLights.Contracts
{
    public interface ITrafficLight : IContext<ISignalState>, ISwitchable
    {
    }
}

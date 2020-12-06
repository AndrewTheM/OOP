namespace TrafficLights.Contracts
{
    public interface ISignalState : IState<ITrafficLight>, ISwitchable
    {
        string SignalName { get; }
    }
}

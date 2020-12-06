namespace TrafficLights.Contracts
{
    public interface IState
    {
    }

    public interface IState<TContext> : IState
        where TContext : IContext
    {
        TContext Context { get; }
    }
}

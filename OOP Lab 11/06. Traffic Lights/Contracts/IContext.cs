namespace TrafficLights.Contracts
{
    public interface IContext
    {
    }

    public interface IContext<TState> : IContext
        where TState : IState
    {
        TState State { get; }

        void ChangeState(TState state);
    }
}

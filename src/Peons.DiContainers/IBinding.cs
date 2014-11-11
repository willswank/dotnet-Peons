namespace Peons.DiContainers
{
    public interface IBinding<TRequested, TResolved> where TResolved : TRequested
    {
        bool InSingletonScope { get; }
    }

    public interface IBinding<TRequested>
    {
        TRequested Constant { get; }
    }
}

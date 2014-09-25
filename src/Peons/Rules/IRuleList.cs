namespace Peons.Rules
{
    public interface IRuleList<T>
    {
        IRule<T>[] Rules { get; }
    }
}

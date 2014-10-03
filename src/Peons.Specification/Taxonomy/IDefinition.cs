namespace Peons.Specification.Taxonomy
{
    /// <summary>
    /// A specification with a genus and differentia
    /// </summary>
    public interface IDefinition<T> : ISpecification<T>
    {
        ISpecification<T> WhyUnsatisfiedBy(T candidate);
    }
}

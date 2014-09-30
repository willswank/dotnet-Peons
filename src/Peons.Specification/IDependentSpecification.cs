namespace Peons.Specification
{
    public interface IDependentSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// A specification with ordered prerequisites
        /// </summary>
        ISpecification<T> WhyUnsatisfiedBy(T candidate);
    }
}

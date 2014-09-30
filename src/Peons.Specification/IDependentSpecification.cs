namespace Peons.Specification
{
    public interface IDependentSpecification<T> : ISpecification<T>
    {
        ISpecification<T> WhyUnsatisfiedBy(T candidate);
    }
}

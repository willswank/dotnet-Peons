using System.Collections.Generic;

namespace Peons.Specification
{
    /// <summary>
    /// A set of specifications that pass or fail together
    /// </summary>
    public interface ISpecificationSet<T>
        : IEnumerable<ISpecification<T>>, ISpecification<T>
    {
        IEnumerable<ISpecification<T>> GetAllSatisfiedBy(T candidate);
        IEnumerable<ISpecification<T>> GetAllUnsatisfiedBy(T candidate);
    }
}

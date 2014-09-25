using System.Collections.Generic;

namespace Peons.Specification
{
    public interface IOrderedSpecificationSet<T>
        : IEnumerable<ISpecification<T>>, ISpecification<T>
    {
        ISpecification<T> this[int index] { get; }
        int Length { get; }
        ISpecification<T> GetFirstUnsatisfiedBy(T candidate);
    }
}

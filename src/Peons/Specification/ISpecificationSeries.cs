using System.Collections.Generic;

namespace Peons.Specification
{
    /// <summary>
    /// An ordered set of specifications in which the first unsatisfied is
    /// the reason for failure
    /// </summary>
    public interface ISpecificationSeries<T>
        : IEnumerable<ISpecification<T>>, ISpecification<T>
    {
        ISpecification<T> this[int index] { get; }
        int Length { get; }
        ISpecification<T> GetFirstUnsatisfiedBy(T candidate);
    }
}

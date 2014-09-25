using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Peons.Specification
{
    public abstract class SpecificationSet<T> : ISpecificationSet<T>
    {
        private readonly ISpecification<T>[] specifications;

        protected SpecificationSet(IEnumerable<ISpecification<T>> specifications)
        {
            if (specifications == null)
                throw new ArgNullException(() => specifications);
            if (specifications.IsEmpty())
                throw new ArgEmptyException(() => specifications);

            this.specifications = specifications.ToArray();
        }

        public IEnumerator<ISpecification<T>> GetEnumerator()
        {
            return this.specifications.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.specifications.GetEnumerator();
        }

        public IEnumerable<ISpecification<T>> GetAllSatisfiedBy(T candidate)
        {
            foreach (var specification in this.specifications)
            {
                if (specification.IsSatisfiedBy(candidate))
                {
                    yield return specification;
                }
            }
        }

        public IEnumerable<ISpecification<T>> GetAllUnsatisfiedBy(T candidate)
        {
            foreach (var specification in this.specifications)
            {
                if (!specification.IsSatisfiedBy(candidate))
                {
                    yield return specification;
                }
            }
        }

        public bool IsSatisfiedBy(T candidate)
        {
            foreach (var specification in this.specifications)
            {
                if (!specification.IsSatisfiedBy(candidate))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Peons.Specification
{
    public abstract class OrderedSpecificationSet<T> : IOrderedSpecificationSet<T>
    {
        private readonly ISpecification<T>[] specifications;

        protected OrderedSpecificationSet(ISpecification<T>[] specifications)
        {
            if (specifications == null)
                throw new ArgNullException(() => specifications);
            if (specifications.IsEmpty())
                throw new ArgEmptyException(() => specifications);

            this.specifications = specifications;
        }

        public ISpecification<T> this[int index]
        {
            get { return this.specifications[index]; }
        }

        public int Length
        {
            get { return this.specifications.Length; }
        }

        public ISpecification<T> GetFirstUnsatisfiedBy(T candidate)
        {
            for (var i = 0; i < this.specifications.Length; i++)
            {
                var specification = this.specifications[i];
                if (!specification.IsSatisfiedBy(candidate))
                {
                    return specification;
                }
            }
            return null;
        }

        public IEnumerator<ISpecification<T>> GetEnumerator()
        {
            return this.specifications.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.specifications.GetEnumerator();
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return this.GetFirstUnsatisfiedBy(candidate) == null;
        }
    }
}

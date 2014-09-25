using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Peons.Specification
{
    public abstract class SpecificationSeries<T> : ISpecificationSeries<T>
    {
        private readonly ISpecification<T>[] specifications;

        protected SpecificationSeries(ISpecification<T>[] specifications)
        {
            if (specifications == null)
                throw new ArgNullException(() => specifications);
            if (specifications.IsEmpty())
                throw new ArgEmptyException(() => specifications);

            this.specifications = specifications.ToArray();
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

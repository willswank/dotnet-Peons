using Peons.Specification;

namespace Peons.Internals.Specification
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> wrappedSpecification;

        public ISpecification<T> WrappedSpecification
        {
            get { return this.wrappedSpecification; }
        }

        public NotSpecification(ISpecification<T> specification)
        {
            if (specification == null)
                throw new ArgNullException(() => specification);

            this.wrappedSpecification = specification;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return !this.WrappedSpecification.IsSatisfiedBy(candidate);
        }
    }
}

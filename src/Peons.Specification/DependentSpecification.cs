using System;
using System.Linq;

namespace Peons.Specification
{
    public abstract class DependentSpecification<T> : IDependentSpecification<T>
    {
        private readonly ISpecification<T>[] prerequisites;

        protected DependentSpecification(ISpecification<T>[] prerequisites)
        {
            if (prerequisites == null)
                throw new ArgNullException(() => prerequisites);
            if (prerequisites.IsEmpty())
                throw new ArgEmptyException(() => prerequisites);

            this.prerequisites = prerequisites.ToArray();
        }

        public ISpecification<T> WhyUnsatisfiedBy(T candidate)
        {
            foreach (var prerequisite in this.prerequisites)
            {
                if (prerequisite is IDependentSpecification<T>)
                {
                    var dependent = prerequisite as IDependentSpecification<T>;
                    var reason = dependent.WhyUnsatisfiedBy(candidate);
                    if (reason != null)
                    {
                        return reason;
                    }
                }
                else if (!prerequisite.IsSatisfiedBy(candidate))
                {
                    return prerequisite;
                }
            }
            if (!this.IsIndividuallySatisfiedBy(candidate))
            {
                return this;
            }
            return null;
        }

        protected abstract bool IsIndividuallySatisfiedBy(T candidate);

        public bool IsSatisfiedBy(T candidate)
        {
            return this.WhyUnsatisfiedBy(candidate) == null;
        }
    }
}

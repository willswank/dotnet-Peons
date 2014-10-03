namespace Peons.Specification.Taxonomy
{
    /// <summary>
    /// A specification with a genus and differentia
    /// </summary>
    public abstract class Definition<T> : IDefinition<T>
    {
        private readonly ISpecification<T> genus;

        protected Definition(ISpecification<T> genus)
        {
            if (genus == null)
                throw new ArgNullException(() => genus);

            this.genus = genus;
        }

        public ISpecification<T> WhyUnsatisfiedBy(T candidate)
        {
            if (this.genus is IDefinition<T>)
            {
                var prerequisite = this.genus as IDefinition<T>;
                var reason = prerequisite.WhyUnsatisfiedBy(candidate);
                if (reason != null)
                {
                    return reason;
                }
            }
            else if (!this.genus.IsSatisfiedBy(candidate))
            {
                return genus;
            }
            if (!this.HasOwnDifferentiaSatisfiedBy(candidate))
            {
                return this;
            }
            return null;
        }

        protected abstract bool HasOwnDifferentiaSatisfiedBy(T candidate);

        public bool IsSatisfiedBy(T candidate)
        {
            return this.WhyUnsatisfiedBy(candidate) == null;
        }
    }
}

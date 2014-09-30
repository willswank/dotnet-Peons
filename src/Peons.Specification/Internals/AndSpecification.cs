namespace Peons.Specification.Internals
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> specificationA;
        private readonly ISpecification<T> specificationB;

        public ISpecification<T> SpecificationA
        {
            get { return this.specificationA; }
        }

        public ISpecification<T> SpecificationB
        {
            get { return this.specificationB; }
        }

        public AndSpecification(ISpecification<T> specificationA, ISpecification<T> specificationB)
        {
            if (specificationA == null)
                throw new ArgNullException(() => specificationA);

            if (specificationB == null)
                throw new ArgNullException(() => specificationB);

            this.specificationA = specificationA;
            this.specificationB = specificationB;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return this.SpecificationA.IsSatisfiedBy(candidate)
                && this.SpecificationB.IsSatisfiedBy(candidate);
        }
    }
}

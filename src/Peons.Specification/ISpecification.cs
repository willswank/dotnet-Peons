﻿namespace Peons.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
    }
}

using System.Collections.Generic;

namespace Peons.Rules
{
    public interface IEnforcer
    {
        IRule<T> GetBrokenRule<T>(IRule<T>[] rules, T target);
    }
}

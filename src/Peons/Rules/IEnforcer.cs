using System.Collections.Generic;

namespace Peons.Rules
{
    public interface IEnforcer<T>
    {
        IRule<T> GetBrokenRule(IRule<T>[] rules, T target);
    }
}

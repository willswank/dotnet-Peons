namespace Peons.Rules
{
    public class Enforcer<T> : IEnforcer<T>
    {
        public IRule<T> GetBrokenRule(IRule<T>[] rules, T target)
        {
            if (rules == null)
                throw new ArgNullException(() => rules);

            foreach (var rule in rules)
            {
                if (!rule.AppliesTo(target))
                {
                    return rule;
                }
            }
            return null;
        }
    }
}
